using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdDocumentEditor
{
    class Section
    {
        public static string SECTION { get => "section"; }
        public static int SECTION_L { get => SECTION.Length; }

        public string Title { get; set; }
        public List<Paragraph> Paragraphs { get; set; }

        public Section()
        {
            Title = string.Empty;
            Paragraphs = new List<Paragraph>();
        }

        public void AddParagraph()
        {
            Paragraphs.Add(new Paragraph());
        }
    }
}
