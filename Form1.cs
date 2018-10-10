using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    }
                    else if (control.Name.Contains(nameof(Document.Author)))
                    {
                        control.DataBindings.Clear();
                        control.DataBindings.Add(nameof(TextBox.Text), _object, nameof(Document.Author));
                    }
                    else if (control.Name.Contains(nameof(Document.Type)))
                    {
                        control.DataBindings.Clear();
                        control.DataBindings.Add(nameof(TextBox.Text), _object, nameof(Document.Type));
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

    }
}
