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
        private int SectionCount { get => docPanel.Controls.Count - 1; }

        private Point NextSectionLocation { get => new Point(sectionDocumentPanel.Location.X, sectionDocumentPanel.Location.Y + DefaultSectionSize.Height * SectionCount); }
        private Point NextParagraphLocation(DocumentPanel section)
        {
            return new Point(paragraphDocumentPanel.Location.X, paragraphDocumentPanel.Location.Y + DefaultParagraphSize.Height * section.ChildPanelCount);
        }

        // Not used really
        private const int sectionMargin = 10;
        private const int paragraphMargin = 10;

        Document _document = new Document();

        public Form1()
        {
            InitializeComponent();

            sectionDocumentPanel.Visible = false;
            addSectionToolStripMenuItem.Click += AddSection;
            InitializeInputEvents(this);

        }

        /*
         * Initializers 
         */
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
                    controlEntry.Click += SwitchToTextBox;
                else if (controlEntry is TextBox)
                {
                    controlEntry.Validated += SwitchToLabel;
                    controlEntry.Visible = false;
                }
            }
        }

        /// <summary>
        /// Initializes events for buttons.
        /// <para>Avaliable events: AddParagraph, RemoveParagraph, RemoveSection</para>
        /// <para>* AddSection is implemented as menuItem explicitly</para>
        /// </summary>
        /// <param name="controlEntry"></param>
        private void InitializeButtonEvents(Control controlEntry)
        {
            if (controlEntry is Panel || controlEntry is DocumentPanel || controlEntry is Form)
                foreach (Control control in controlEntry.Controls)
                    InitializeButtonEvents(control);
            else
            {
                if (controlEntry is Button)
                {
                    if (controlEntry.Name == DocumentPanel.AddParagraphButton)
                        controlEntry.Click += AddParagraph;
                    else if (controlEntry.Name == DocumentPanel.RemoveParagraphButton)
                        controlEntry.Click += RemoveParagraph;
                    else if (controlEntry.Name == DocumentPanel.RemoveSectionButton)
                        controlEntry.Click += RemoveSection;
                }
            }
        }
        /// <summary>
        /// Coordinates controls with data structure, or in other words front-end and back-end.
        /// <para>Supposed to be called when a new Section/Paragraph was created.</para>
        /// <para>Basically, creates a new Section/Paragraph and binds it to a given controlEntry.</para>
        /// </summary>
        /// <param name="controlEntry"></param>
        /// <param name="_object"></param>
        private void InitializeDataSync(DocumentPanel controlEntry, Document _object)
        {
            if (controlEntry.BaseName == Section.section)
            {
                _object.AddSection();
                controlEntry.AssignDataBindings(_object);
            }
            else if (controlEntry.BaseName == Paragraph.paragraph)
            {
                DocumentPanel activeSection = controlEntry.Parent as DocumentPanel;
                _object.Sections[activeSection.Id].AddParagraph();
                controlEntry.AssignDataBindings(_object);
            }
            else throw new TypeAccessException();
        }

        /// <summary>
        /// Call all initializers to fully implement a controlEntry into the programm.
        /// </summary>
        /// <param name="controlEntry"></param>
        /// <param name="_object"></param>
        private void InitializeDocumentControl(DocumentPanel controlEntry, Document _object)
        {
            InitializeInputEvents(controlEntry);
            InitializeButtonEvents(controlEntry);
            InitializeDataSync(controlEntry, _object);
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
            eventCaller.Visible = false;
            string baseName = ControlUtility.GetSimpleBaseName(eventCaller);
            Control parentContainer = eventCaller.Parent;
            parentContainer.Controls[ControlUtility.GetLabelName(baseName)].Visible = true;
        }

        private void AddSection(object sender, EventArgs e)
        {
            DocumentPanel newSection = new DocumentPanel(sectionDocumentPanel)
            {
                Id = SectionCount
            };

            Point currentScroll = docPanel.AutoScrollPosition;
            docPanel.AutoScrollPosition = new Point(0, 0);
            newSection.Location = NextSectionLocation;
            docPanel.AutoScrollPosition = currentScroll;

            docPanel.Controls.Add(newSection);
            InitializeDocumentControl(newSection, _document);
        }

        private void RemoveSection(object sender, EventArgs e)
        {

        }

        private void AddParagraph(object sender, EventArgs e)
        {
            DocumentPanel currentParagraph = (sender as Button).Parent as DocumentPanel;
            currentParagraph.Controls[DocumentPanel.AddParagraphButton].Visible = false;
            DocumentPanel activeSection = currentParagraph.Parent as DocumentPanel;

            DocumentPanel newParagraph = new DocumentPanel(paragraphDocumentPanel)
            {
                Id = activeSection.ChildPanelCount
            };

            Point currentScroll = activeSection.AutoScrollPosition;
            activeSection.AutoScrollPosition = new Point(0, 0);
            newParagraph.Location = NextParagraphLocation(activeSection);
            activeSection.AutoScrollPosition = currentScroll;

            activeSection.Controls.Add(newParagraph);
            //Initialization has to be performed after addition to controls
            //because it has to refer to parent element.
            InitializeDocumentControl(newParagraph, _document);
        }

        private void RemoveParagraph(object sender, EventArgs e)
        {

        }

    }
}
