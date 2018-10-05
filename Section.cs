using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdDocumentEditor
{
    class Section
    {
        public string Title { get; set; }
        public List<Paragraph> Paragraphs { get; set; }

        public Section()
        {
            Title = string.Empty;
            Paragraphs = new List<Paragraph>();
        }
    }
}
