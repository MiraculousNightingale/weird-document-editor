using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeirdDocumentEditor
{
    static class ControlUtility
    {
        /*
         * Static constants for convenience
         */
        public static string PANEL { get => "Panel"; }
        public static string BUTTON { get => "Button"; }
        public static string RICHTEXTBOX { get => "RichTextBox"; }
        public static string TEXTBOX { get => "TextBox"; }
        public static string LABEL { get => "Label"; }
        public static int PANEL_L { get => PANEL.Length; }
        public static int BUTTON_L { get => BUTTON.Length; }
        public static int RICHTEXTBOX_L { get => RICHTEXTBOX.Length; }
        public static int TEXTBOX_L { get => TEXTBOX.Length; }
        public static int LABEL_L { get => LABEL.Length; }

        /*
         * Factory methods to generale control names
         */
        public static string GetPanelName(string baseName, int id)
        {
            return baseName + id.ToString() + PANEL;
        }

        public static string GetButtonName(string baseName, int id)
        {
            return baseName + id.ToString() + BUTTON;
        }

        public static string GetRichTextBoxName(string baseName, int id)
        {
            return baseName + id.ToString() + RICHTEXTBOX;
        }

        public static string GetTextBoxName(string baseName, int id)
        {
            return baseName + id.ToString() + TEXTBOX;
        }

        public static string GetLabelName(string baseName, int id)
        {
            return baseName + id.ToString() + LABEL;
        }

        /*
         * Control interaction utilities
         */
        public static string GetBaseName(Control control)
        {
            string _type = control.GetType().Name;
            return control.Name.Contains(_type) ? control.Name.Replace(_type, string.Empty) : control.Name;
        }

        public static string GetIdentifiedName(Control control, int id)
        {
            string _type = control.GetType().Name;
            return control.Name = GetBaseName(control) + id.ToString() + _type;
        }

        public static Control SetId(Control control, int id)
        {
            control.Name = GetIdentifiedName(control, id);
            return control;
        }


    }
}
