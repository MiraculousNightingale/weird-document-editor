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

        private void SwitchToTextBox(object sender, EventArgs e)
        {
            Label eventCaller = sender as Label;
            eventCaller.Visible = false;
            string baseName = ControlUtility.GetBaseName(eventCaller);
            TextBox replacer = eventCaller.Parent.Controls[baseName + ControlUtility.TEXTBOX] as TextBox;
            replacer.Visible = true;
            replacer.Focus();
        }

        private void SwitchToLabel(object sender, EventArgs e)
        {
            TextBox eventCaller = sender as TextBox;
            eventCaller.Visible = false;
            string baseName = ControlUtility.GetBaseName(eventCaller);
            eventCaller.Parent.Controls[baseName + ControlUtility.LABEL].Visible = true;
        }

        private void AddSection(object sender, EventArgs e)
        {
            DocumentPanel newSection = new DocumentPanel(sectionDocumentPanel);
            newSection.Id = SectionCount;
            newSection.Location = NextSectionLocation;
            InitializeInputEvents(newSection);
            InitializeButtonEvents(newSection);
            docPanel.Controls.Add(newSection);
        }

        private void RemoveSection(object sender, EventArgs e)
        {

        }

        private void AddParagraph(object sender, EventArgs e)
        {
            DocumentPanel currentParagraph = (sender as Button).Parent as DocumentPanel;
            DocumentPanel activeSection = currentParagraph.Parent as DocumentPanel;

            DocumentPanel newParagraph = new DocumentPanel(paragraphDocumentPanel);
            newParagraph.Id = activeSection.ChildPanelCount;

            Point currentScroll = activeSection.AutoScrollPosition;
            activeSection.AutoScrollPosition = new Point(0, 0);
            newParagraph.Location = NextParagraphLocation(activeSection);
            activeSection.AutoScrollPosition = currentScroll;

            InitializeInputEvents(newParagraph);
            InitializeButtonEvents(newParagraph);
            activeSection.Controls.Add(newParagraph);

            currentParagraph.Controls[DocumentPanel.AddParagraphButton].Visible = false;
        }

        private void RemoveParagraph(object sender, EventArgs e)
        {

        }

    }
}
