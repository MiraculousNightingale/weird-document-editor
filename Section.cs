using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdDocumentEditor
{
    public class Section
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
        }

        public Section(int paragraphCount)
        {
            Title = string.Empty;
            Paragraphs=new List<Paragraph>();
            AddParagraph();
        }
        /// <summary>
        /// Add new Paragraph in current Section
        /// </summary>
        public void AddParagraph()
        {
            Paragraphs.Add(new Paragraph());
        }

        public void InsertParagraph(int id)
        {
            if (id == Paragraphs.Count - 1)
                Paragraphs.Add(new Paragraph());
            else
                Paragraphs.Insert(id, new Paragraph());
        }

        public void RemoveParagraph(int id)
        {
            Paragraphs.RemoveAt(id);
        }
    }
}
