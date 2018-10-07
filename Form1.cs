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
        private Size DefaultSectionSize { get => sectionPanel.Size; }
        private int SectionCount { get => docPanel.Controls.Count - 1; }
        private Point NextSectionLocation { get => new Point(sectionPanel.Location.X, sectionPanel.Location.Y + DefaultSectionSize.Height * SectionCount); }

        private const int sectionMargin = 10;

        Document _document = new Document();

        public Form1()
        {
            InitializeComponent();

            sectionPanel.Visible = false;
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

        private void SwitchToTextBox(object sender, EventArgs e)
        {
            Label eventCaller = sender as Label;
            eventCaller.Visible = false;
            string baseName = eventCaller.Name.Substring(0, eventCaller.Name.Length - "Label".Length);
            TextBox replacer = eventCaller.Parent.Controls[baseName + "TextBox"] as TextBox;
            replacer.Visible = true;
            replacer.Focus();
        }

        private void SwitchToLabel(object sender, EventArgs e)
        {
            TextBox eventCaller = sender as TextBox;
            eventCaller.Visible = false;
            string baseName = eventCaller.Name.Substring(0, eventCaller.Name.Length - "TextBox".Length);
            eventCaller.Parent.Controls[baseName + "Label"].Visible = true;
        }

        private void AddSection(object sender, EventArgs e)
        {
            DocumentPanel NewSection = new DocumentPanel(sectionPanel);
            NewSection.SetId(SectionCount);
            NewSection.Location = NextSectionLocation;
            InitializeInputEvents(NewSection);
            docPanel.Controls.Add(NewSection);
        }

        private void RemoveSection(object sender, EventArgs e)
        {

        }

        private void AddParagraph(object sender, EventArgs e)
        {

        }

        private void RemoveParagraph(object sender, EventArgs e)
        {

        }

    }
}
