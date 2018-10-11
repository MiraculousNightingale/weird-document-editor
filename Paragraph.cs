using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdDocumentEditor
{
    public class Paragraph
    {
        public static string PARAGRAPH { get => "Paragraph"; }
        public static string paragraph { get => PARAGRAPH.ToLower(); }
        public static int PARAGRAPH_L { get => PARAGRAPH.Length; }

        public string Title { get; set; }
        public string Text { get; set; }

        public Paragraph()
        {
            Title = string.Empty;
            Text = string.Empty;
            //Debug
            //Title = "NewParagraph";
            //Text = "NewParagraph";
        }
    }
}
