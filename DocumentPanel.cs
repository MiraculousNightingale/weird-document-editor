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
        public static string DOCUMENTPANEL { get => "DocumentPanel"; }
        public static int DOCUMENTPANEL_L { get => DOCUMENTPANEL.Length; }
        public static string AddParagraphButton { get => "add" + Paragraph.PARAGRAPH + ControlUtility.BUTTON; }
        public static string RemoveParagraphButton { get => "remove" + Paragraph.PARAGRAPH + ControlUtility.BUTTON; }
        public static string RemoveSectionButton { get => "remove" + Section.SECTION + ControlUtility.BUTTON; }
        public string BaseName { get => ControlUtility.GetBaseName(this); }
        //public string BaseName { get => Name.Contains(DOCUMENTPANEL) ? Name.Replace(DOCUMENTPANEL, string.Empty) : Name; }

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
        /*
         * Panel Deep copy constructor
         */
        public DocumentPanel(Panel copyFrom)
        {
            Name = copyFrom.Name;
            Size = new Size(copyFrom.Size.Width, copyFrom.Size.Height);
            // By default DocumentPanels should be only scrolled downwards
            HorizontalScroll.Maximum = 0;
            AutoScroll = copyFrom.AutoScroll;
            AutoSize = copyFrom.AutoSize;
            AutoSizeMode = copyFrom.AutoSizeMode;
            Location = new Point(copyFrom.Location.X, copyFrom.Location.Y);
            foreach (Control control in copyFrom.Controls)
            {
                if (control is Panel) Controls.Add(new DocumentPanel(control as Panel));
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

        // Sets the id in controls Name attribute
        private void SetId(int id)
        {
            Name = ControlUtility.GetIdentifiedName(this as Panel, id);
            foreach (Control control in Controls)
                // Nullified id is used instead because section paragraphs begin from 0 each time and scale on with ChildPanelCount
                //if (control is Panel) (control as DocumentPanel).SetId(id);
                if (control is Panel) (control as DocumentPanel).SetId(0);
                else if (!(control is Button)) control.Name = ControlUtility.GetIdentifiedName(control, id);
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

        // Assign Data Bindings to each control
        public void AssignDataBindings()
        {
            return;
        }


    }
}
