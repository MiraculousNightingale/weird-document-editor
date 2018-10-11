using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WeirdDocumentEditor
{
    public partial class Form1 : Form
    {
        private Size DefaultSectionSize { get => sectionDocumentPanel.Size; }
        private Size DefaultParagraphSize { get => paragraphDocumentPanel.Size; }
        private int SectionCount { get => mainDocumentPanel.Controls.Count - 1; }

        private Point NextSectionLocation { get => new Point(sectionDocumentPanel.Location.X, sectionDocumentPanel.Location.Y + DefaultSectionSize.Height * SectionCount); }
        private Point NextParagraphLocation(DocumentPanel section)
        {
            return new Point(paragraphDocumentPanel.Location.X, paragraphDocumentPanel.Location.Y + DefaultParagraphSize.Height * section.ChildPanelCount);
        }

        // Not used really
        private const int sectionMargin = 10;
        private const int paragraphMargin = 10;

        Document _document = new Document();
        DocumentPanel mainPanel;

        public Form1()
        {
            InitializeComponent();
            //Hide templates
            paragraphDocumentPanel.Visible = false;
            sectionDocumentPanel.Visible = false;
            mainDocumentPanel.Visible = false;
            //Menu events
            newToolStripMenuItem.Click += NewDocument;
            openToolStripMenuItem.Click += OpenDocument;
            saveToolStripMenuItem.Click += SaveDocument;
            saveAsToolStripMenuItem.Click += SaveAsDocument;
            addSectionToolStripMenuItem.Click += AddSection;
            //Base controls
            mainPanel = new DocumentPanel(mainDocumentPanel);
            mainPanel.BoundDocument = _document;
            Controls.Add(mainPanel);
            //Initializers
            InitializeInputEvents(this);
            InitializeDocAttributeBindings(this, _document);

        }

        /*
         * Initializers 
         */
        private void InitializeDocAttributeBindings(Control entryControl, Document _object)
        {
            foreach (Control control in entryControl.Controls)
                if (control is Label || control is TextBox)
                    if (control.Name.Contains(nameof(Document.Title)))
                    {
                        control.DataBindings.Clear();
                        control.DataBindings.Add(nameof(TextBox.Text), _object, nameof(Document.Title));
                        control.Visible = false;
                        control.Visible = true;
                    }
                    else if (control.Name.Contains(nameof(Document.Author)))
                    {
                        control.DataBindings.Clear();
                        control.DataBindings.Add(nameof(TextBox.Text), _object, nameof(Document.Author));
                        control.Visible = false;
                        control.Visible = true;
                    }
                    else if (control.Name.Contains(nameof(Document.Type)))
                    {
                        control.DataBindings.Clear();
                        control.DataBindings.Add(nameof(TextBox.Text), _object, nameof(Document.Type));
                        control.Visible = false;
                        control.Visible = true;
                    }
        }
        /// <summary>
        /// Initializes input events for a control.
        /// <para>Parameter can be any control: Panel, DocumentPanel, Form, Label, TextBox</para>
        /// <para>* Events differ for Label and TextBox and for Panel, DocumentPanel or Form method is called recursively</para>
        /// </summary>
        /// <param name="controlEntry"></param>
        private void InitializeInputEvents(Control controlEntry)
        {
            if (controlEntry is Panel || controlEntry is DocumentPanel || controlEntry is Form)
                foreach (Control control in controlEntry.Controls)
                    InitializeInputEvents(control);
            else
            {
                if (controlEntry is Label)
                {
                    if (!controlEntry.Name.Contains(DocumentPanel.STATIC_LABEL))
                    {
                        controlEntry.Click += SwitchToTextBox;
                        controlEntry.VisibleChanged += EmptyLabelSwitch;
                    }
                }
                else if (controlEntry is TextBox)
                {
                    controlEntry.Validated += SwitchToLabel;
                    controlEntry.Visible = false;
                }
            }
        }

        /*
         * Events 
         */
        private void SwitchToTextBox(object sender, EventArgs e)
        {
            Label eventCaller = sender as Label;
            eventCaller.Visible = false;
            string baseName = ControlUtility.GetSimpleBaseName(eventCaller);
            Control parentContainer = eventCaller.Parent;
            TextBox replacer = parentContainer.Controls[ControlUtility.GetTextBoxName(baseName)] as TextBox;
            replacer.Visible = true;
            replacer.Focus();
        }

        private void SwitchToLabel(object sender, EventArgs e)
        {
            TextBox eventCaller = sender as TextBox;
            if (!string.IsNullOrWhiteSpace(eventCaller.Text))
            {
                eventCaller.Visible = false;
                string baseName = ControlUtility.GetSimpleBaseName(eventCaller);
                Control parentContainer = eventCaller.Parent;
                parentContainer.Controls[ControlUtility.GetLabelName(baseName)].Visible = true;
            }
        }

        /// <summary>
        /// If a Label is empty - show TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmptyLabelSwitch(object sender, EventArgs e)
        {
            Label eventCaller = sender as Label;
            if (string.IsNullOrWhiteSpace(eventCaller.Text))
            {
                eventCaller.Visible = false;
                string baseName = ControlUtility.GetSimpleBaseName(eventCaller);
                Control parentContainer = eventCaller.Parent;
                TextBox replacer = parentContainer.Controls[ControlUtility.GetTextBoxName(baseName)] as TextBox;
                replacer.Visible = true;
            }
        }

        private void AddSection(object sender, EventArgs e)
        {
            _document.AddSection();
            mainPanel.RenderChildPanelsRecursion();
            mainPanel.AssignBindings();

        }
        private string currentDocument = string.Empty;
        private void SaveDocument(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentDocument))
                SaveAsDocument(sender, e);
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Document));
                TextWriter textWriter = new StreamWriter(@currentDocument);
                serializer.Serialize(textWriter, _document);
                textWriter.Close();
            }
        }

        private SaveFileDialog SFD = new SaveFileDialog
        {
            FileName = string.Empty,
            DefaultExt = "wdoc",
            Filter = "Weird Document (*.wdoc)|*.wdoc|All files (*.*)|*.*",
            CheckFileExists = false,
            CheckPathExists = true,
            RestoreDirectory = true
        };
        private void SaveAsDocument(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Document));
                TextWriter textWriter = new StreamWriter(@SFD.FileName);
                serializer.Serialize(textWriter, _document);
                textWriter.Close();

                currentDocument = SFD.FileName;
            }
        }

        private OpenFileDialog OFD = new OpenFileDialog
        {
            FileName = string.Empty,
            DefaultExt = "wdoc",
            Filter = "Weird Document (*.wdoc)|*.wdoc|All files (*.*)|*.*",
            CheckFileExists = true,
            CheckPathExists = true,
            RestoreDirectory = true
        };
        private void OpenDocument(object sender, EventArgs e)
        {
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Document));
                TextReader textReader = new StreamReader(@OFD.FileName);
                _document = serializer.Deserialize(textReader) as Document;
                textReader.Close();
                InitializeDocAttributeBindings(this, _document);
                mainPanel.BoundDocument = _document;

                currentDocument = OFD.FileName;
                mainPanel.RenderChildPanelsRecursion();
                mainPanel.AssignBindings();
            }
        }

        private void NewDocument(object sender, EventArgs e)
        {
            _document = new Document();
            InitializeDocAttributeBindings(this, _document);
            mainPanel.BoundDocument = _document;
            mainPanel.RenderChildPanelsRecursion();
            mainPanel.AssignBindings();

            currentDocument = string.Empty;
        }

    }
}
