using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdDocumentEditor
{
    class Document
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public List<Section> Sections { get; set; }

        public Document()
        {
            Title = string.Empty;
            Author = string.Empty;
            Type = string.Empty;
            Sections = new List<Section>();
        }

        public void AddSection()
        {
            Sections.Add(new Section());
        }


    }
}
