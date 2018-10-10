using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeirdDocumentEditor
{
    class DocumentPanel : Panel
    {
        //Binding names constants
        private const string main = "main";
        private const string section = "section";
        private const string paragraph = "paragraph";

        public static string STATIC_LABEL { get => "StaticLabel"; }
        public static string DOCUMENTPANEL { get => "DocumentPanel"; }

        public static string AddParagraphButton { get => "add" + Paragraph.PARAGRAPH + ControlUtility.BUTTON; }
        public static string RemoveParagraphButton { get => "remove" + Paragraph.PARAGRAPH + ControlUtility.BUTTON; }
        public static string RemoveSectionButton { get => "remove" + Section.SECTION + ControlUtility.BUTTON; }

        public string BaseName { get => ControlUtility.GetBaseName(this); }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; SetId(id); }
        }

        public int ChildPanelCount
        {
            get
            {
                int _count = 0;
                foreach (Control control in Controls)
                    if (control is DocumentPanel) _count++;
                return _count;
            }
        }
        public DocumentPanel FirstChildPanel { get => GetChildPanelById(0); }
        public DocumentPanel LastChildPanel { get => GetChildPanelById(ChildPanelCount - 1); }
        public Panel ChildTemplate { get; set; }
        private Point NextChildPanelLocation
        {
            get => new Point(ChildTemplate.Location.X, ChildTemplate.Location.Y + ChildTemplate.Size.Height * ChildPanelCount);
        }

        //private Document _boundDocument;
        public Document BoundDocument { get; set; }

        /*
         * Panel Deep copy constructor
         */
        /// <summary>
        /// Deep copy constructor from Panel object.
        /// </summary>
        /// <param name="copyFrom"></param>
        public DocumentPanel(Panel copyFrom)
        {
            Name = copyFrom.Name;
            Size = new Size(copyFrom.Size.Width, copyFrom.Size.Height);
            // By default DocumentPanels should be only scrolled downwards
            HorizontalScroll.Maximum = 0;
            AutoScroll = copyFrom.AutoScroll;
            AutoSize = copyFrom.AutoSize;
            AutoSizeMode = copyFrom.AutoSizeMode;
            BorderStyle = copyFrom.BorderStyle;
            Location = new Point(copyFrom.Location.X, copyFrom.Location.Y);
            foreach (Control control in copyFrom.Controls)
            {
                if (control is Panel)
                {
                    ChildTemplate = control as Panel;
                    //Recursion may be irrational and pointless
                    //Controls.Add(new DocumentPanel(control as Panel));
                }
                else
                {
                    Control Copy = new Control();
                    if (control is Label)
                        Copy = new Label { TextAlign = (control as Label).TextAlign };
                    else if (control is TextBox)
                        Copy = new TextBox { TextAlign = (control as TextBox).TextAlign };
                    else if (control is RichTextBox) Copy = new RichTextBox();
                    else if (control is Button)
                        Copy = new Button { TextAlign = (control as Button).TextAlign };

                    Copy.Name = control.Name;
                    Copy.Size = new Size(control.Size.Width, control.Size.Height);
                    Copy.Font = control.Font;
                    Copy.Text = control.Text;
                    Copy.Location = new Point(control.Location.X, control.Location.Y);

                    Controls.Add(Copy);
                }
            }
        }

        /// <summary>
        /// Sets the id this object to given value explicitly.
        /// <para>* Changes names of this DocumentPanel's controls, but not Child DocumentPanels.</para>
        /// <para>* To indexate Child DocumentPanels use IndexateChildPanels() instead.</para>
        /// </summary>
        /// <param name="id"></param>
        private void SetId(int id)
        {
            Name = ControlUtility.GetIdentifiedName(this, id);
            foreach (Control control in Controls)
                //if (control is DocumentPanel) (control as DocumentPanel).SetId(id);
                //else 
                if (!(control is Button) && !control.Name.Contains(STATIC_LABEL)) control.Name = ControlUtility.GetIdentifiedName(control, id);
        }

        /// <summary>
        /// Reassigns indexes for Child DocumentPanels.
        /// </summary>
        public void IndexateChildPanels()
        {
            int _increment = 0;
            foreach (Control control in Controls.OfType<DocumentPanel>())
            {
                (control as DocumentPanel).Id = _increment;
                (control as DocumentPanel).IndexateChildPanels();
                _increment++;
            }
        }

        /*
         * Location shifters
         */
        public void ShiftLocation(int shiftX, int shiftY)
        {
            Location = new Point(Location.X + shiftX, Location.Y + shiftY);
        }

        public void ShiftX(int shift)
        {
            Location = new Point(Location.X + shift, Location.Y);
        }

        public void ShiftY(int shift)
        {
            Location = new Point(Location.X, Location.Y + shift);
        }

        /// <summary>
        /// Searches a Child Control of type DocumentPanel in Controls by id.
        /// <para>* If not found, throws IndexOutOfRange exception.</para>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DocumentPanel GetChildPanelById(int id)
        {
            foreach (DocumentPanel control in Controls.OfType<DocumentPanel>())
            {
                if (control.Id == id) return control;
            }
            throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// Removes all Child DocumentPanels.
        /// </summary>
        public void CleanUpChildPanels()
        {
            List<Control> RemoveControls = new List<Control>(Controls.OfType<DocumentPanel>());
            foreach (Control control in RemoveControls)
                Controls.Remove(control);
        }
        /// <summary>
        /// Assings data bindings to controls of this DocumentPanel.
        /// <para>Binds each control of this and child DocumentPanel objects recursively
        /// according to object basenames(section/paragraph) and child control types.</para>
        /// </summary>
        /// <param name="_object"></param>
        public void AssignBindings()
        {
            foreach (Control control in Controls)
            {
                if (control is DocumentPanel)
                {
                    //(control as DocumentPanel).BoundDocument = BoundDocument;
                    (control as DocumentPanel).AssignBindings();
                }
                else
                    switch (BaseName)
                    {
                        case section:
                            // Id in current context is Id of the active section
                            if ((control is Label || control is TextBox) && !control.Name.Contains(STATIC_LABEL))
                            {
                                control.DataBindings.Clear();
                                control.DataBindings.Add(nameof(TextBox.Text), BoundDocument.Sections[Id], nameof(Section.Title));
                            }
                            break;
                        case paragraph:
                            DocumentPanel activeSection = Parent as DocumentPanel;
                            if ((control is Label || control is TextBox) && !control.Name.Contains(STATIC_LABEL))
                            {
                                control.DataBindings.Clear();
                                control.DataBindings.Add(nameof(TextBox.Text), BoundDocument.Sections[activeSection.Id].Paragraphs[Id], nameof(Paragraph.Title));
                            }
                            else if (control is RichTextBox)
                            {
                                control.DataBindings.Clear();
                                control.DataBindings.Add(nameof(RichTextBox.Text), BoundDocument.Sections[activeSection.Id].Paragraphs[Id], nameof(Paragraph.Text));
                            }
                            break;
                        default:
                            break;
                    }
            }
        }

        public void RenderChildPanelsRecursion()
        {
            RenderChildPanels();
            foreach (DocumentPanel control in Controls.OfType<DocumentPanel>())
            {
                control.RenderChildPanelsRecursion();
            }
        }

        public void RenderChildPanels()
        {
            switch (BaseName)
            {
                case main:
                    CleanUpChildPanels();
                    foreach (Section section in BoundDocument.Sections)
                        RenderChildPanel();
                    break;
                case section:
                    CleanUpChildPanels();
                    foreach (Paragraph paragraph in BoundDocument.Sections[Id].Paragraphs)
                        RenderChildPanel();
                    break;
                default:
                    break;
            }
        }

        private void RenderChildPanel()
        {
            DocumentPanel newPanel = new DocumentPanel(ChildTemplate)
            {
                Id = ChildPanelCount,
                BoundDocument = BoundDocument
            };

            int initialScroll = VerticalScroll.Value;
            VerticalScroll.Value = VerticalScroll.Minimum;

            newPanel.Location = NextChildPanelLocation;

            VerticalScroll.Value = initialScroll;

            newPanel.InitializeInputEvents();
            newPanel.InitializeButtonEvents();

            Controls.Add(newPanel);
        }

        private void InitializeInputEvents()
        {
            foreach (Control control in Controls)
                if (control is Label)
                {
                    if (!control.Name.Contains(STATIC_LABEL))
                    {
                        control.Click += SwitchToTextBox;
                        control.Paint += EmptyLabelSwitch;
                    }
                }
                else if (control is TextBox)
                {
                    control.Validated += SwitchToLabel;
                    control.Visible = false;
                }
        }

        private void InitializeButtonEvents()
        {
            foreach (Control control in Controls.OfType<Button>())
                if (control.Name == AddParagraphButton)
                    control.Click += AddParagraph;
                else if (control.Name == RemoveParagraphButton)
                    control.Click += RemoveParagraph;
                else if (control.Name == RemoveSectionButton)
                    control.Click += RemoveSection;
        }

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

        public void AddSection(object sender, EventArgs e)
        {
            DocumentPanel activeSection = (sender as Button).Parent as DocumentPanel;
            DocumentPanel mainContainer = activeSection.Parent as DocumentPanel;
            BoundDocument.Sections[activeSection.Id].AddParagraph();
            mainContainer.RenderChildPanels();
            mainContainer.AssignBindings();
        }

        private void RemoveSection(object sender, EventArgs e)
        {
            DocumentPanel activeSection = (sender as Button).Parent as DocumentPanel;
            DocumentPanel mainContainer = activeSection.Parent as DocumentPanel;
            BoundDocument.RemoveSection(activeSection.Id);
            mainContainer.RenderChildPanelsRecursion();
            mainContainer.AssignBindings();
        }

        private void AddParagraph(object sender, EventArgs e)
        {
            DocumentPanel activeParagraph = (sender as Button).Parent as DocumentPanel;
            DocumentPanel activeSection = activeParagraph.Parent as DocumentPanel;
            BoundDocument.Sections[activeSection.Id].InsertParagraph(activeParagraph.Id);
            activeSection.RenderChildPanels();
            activeSection.AssignBindings();
        }

        private void RemoveParagraph(object sender, EventArgs e)
        {
            DocumentPanel activeParagraph = (sender as Button).Parent as DocumentPanel;
            DocumentPanel activeSection = activeParagraph.Parent as DocumentPanel;
            BoundDocument.Sections[activeSection.Id].RemoveParagraph(activeParagraph.Id);
            activeSection.RenderChildPanels();
            activeSection.AssignBindings();
        }


    }
}
