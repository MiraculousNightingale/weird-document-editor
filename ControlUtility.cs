using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static string TEXT { get => "Text"; }

        /*
         * Factory methods to generale control names
         */
         /// <summary>
         /// Generate a Panel name in standardized fashion "baseNameIdPanel"
         /// <para>*May be used for baseNames without digits</para>
         /// </summary>
         /// <param name="baseName"></param>
         /// <param name="id"></param>
         /// <returns></returns>
        public static string GetPanelName(string baseName, int id)
        {
            return baseName + id.ToString() + PANEL;
        }

        /// <summary>
        /// Generate a Panel name in standardized fashion "baseNamePanel"
        /// <para>*May be used for baseNames with digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <returns></returns>
        public static string GetPanelName(string baseName)
        {
            return baseName + PANEL;
        }

        /// <summary>
        /// Generate a Button name in standardized fashion "baseNameIdButton"
        /// <para>*May be used for baseNames without digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetButtonName(string baseName, int id)
        {
            return baseName + id.ToString() + BUTTON;
        }

        /// <summary>
        /// Generate a Button name in standardized fashion "baseNameButton"
        /// <para>*May be used for baseNames with digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <returns></returns>
        public static string GetButtonName(string baseName)
        {
            return baseName + BUTTON;
        }

        /// <summary>
        /// Generate a RichTextBox name in standardized fashion "baseNameIdRichTextBox"
        /// <para>*May be used for baseNames without digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetRichTextBoxName(string baseName, int id)
        {
            return baseName + id.ToString() + RICHTEXTBOX;
        }

        /// <summary>
        /// Generate a RichTextBox name in standardized fashion "baseNameRichTextBox"
        /// <para>*May be used for baseNames with digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <returns></returns>
        public static string GetRichTextBoxName(string baseName)
        {
            return baseName + RICHTEXTBOX;
        }

        /// <summary>
        /// Generate a TextBox name in standardizeoutd fashion "baseNameIdTextBox"
        /// <para>*May be used for baseNames with digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetTextBoxName(string baseName, int id)
        {
            return baseName + id.ToString() + TEXTBOX;
        }

        /// <summary>
        /// Generate a TextBox name in standardized fashion "baseNameTextBox"
        /// <para>*May be used for baseNames with digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <returns></returns>
        public static string GetTextBoxName(string baseName)
        {
            return baseName + TEXTBOX;
        }

        /// <summary>
        /// Generate a Label name in standardized fashion "baseNameIdLabel"
        /// <para>*May be used for baseNames without digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetLabelName(string baseName, int id)
        {
            return baseName + id.ToString() + LABEL;
        }

        /// <summary>
        /// Generate a Label name in standardized fashion "baseNameLabel"
        /// <para>*May be used for baseNames with digits</para>
        /// </summary>
        /// <param name="baseName"></param>
        /// <returns></returns>
        public static string GetLabelName(string baseName)
        {
            return baseName + LABEL;
        }

        /*
         * Control interaction utilities
         */
        /// <summary>
        /// Get the base name of a control, without type name, without any digits.
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static string GetBaseName(Control control)
        {
            string _type = control.GetType().Name;
            return control.Name.Contains(_type) ? Regex.Replace(control.Name.Replace(_type, string.Empty), @"[\d-]", string.Empty) :
                // If you consider non-typified names basenames then use this instead of latter
                //control.Name;
                Regex.Replace(control.Name, @"[\d-]", string.Empty);
        }

        /// <summary>
        /// Get the base name of a control, without type name, but retaining digits if there are any. 
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static string GetSimpleBaseName(Control control)
        {
            string _type = control.GetType().Name;
            return control.Name.Contains(_type) ? control.Name.Replace(_type, string.Empty) : control.Name;
        }

        /// <summary>
        /// Generate a control name in a standardized fashion "baseNameIdType".
        /// <para>
        /// Example: noteTitle1Label
        /// </para>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetIdentifiedName(Control control, int id)
        {
            string _type = control.GetType().Name;
            return control.Name = GetBaseName(control) + id.ToString() + _type;
        }

        /// <summary>
        /// Sets the generated identified name for a control.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Control SetId(Control control, int id)
        {
            control.Name = GetIdentifiedName(control, id);
            return control;
        }


    }
}
