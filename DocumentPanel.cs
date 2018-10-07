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
        public string BaseName { get => Name.Contains(ControlUtility.PANEL) ? Name.Replace(ControlUtility.PANEL, string.Empty) : Name; }

        /*
         * Panel Deep copy constructor
         */
        public DocumentPanel(Panel copyFrom)
        {
            Name = copyFrom.Name;
            Size = new Size(copyFrom.Size.Width, copyFrom.Size.Height);
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
        public void SetId(int id)
        {
            Name = ControlUtility.GetIdentifiedName(this as Panel, id);
            foreach (Control control in Controls)
                if (control is Panel) (control as DocumentPanel).SetId(id);
                else control.Name = ControlUtility.GetIdentifiedName(control, id);
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
