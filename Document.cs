using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdDocumentEditor
{
    public class Document
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
            //Debug
            //Title = "";
            //Author = "TozheHui";
            //Type = "Takoi zhe";
            Sections = new List<Section>();
        }

        /// <summary>
        /// Add new Section in current Document
        /// </summary>
        public void AddSection()
        {
            Sections.Add(new Section(1));
        }

        public void RemoveSection(int id)
        {
            Sections.RemoveAt(id);
        }


    }
}
