using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdDocumentEditor
{
    class Section
    {
        public static string SECTION { get => "Section"; }
        public static string section { get => SECTION.ToLower(); }
        public static int SECTION_L { get => SECTION.Length; }

        public string Title { get; set; }
        public List<Paragraph> Paragraphs { get; set; }

        public Section()
        {
            Title = string.Empty;
            //Debug
            //Title = "NewSection";
            Paragraphs = new List<Paragraph>();
            AddParagraph();
        }
        /// <summary>
        /// Add new Paragraph in current Section
        /// </summary>
        public void AddParagraph()
        {
            Paragraphs.Add(new Paragraph());
        }
    }
}
