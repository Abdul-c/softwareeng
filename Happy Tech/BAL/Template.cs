using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Tech.BAL
{
    class Template
    {
        public string TemplateName { get; set; }
        public string Section1 { get; set; }
        public string Section2 { get; set; }
        public string Section3 { get; set; }

        public Template(string templateName, string section1, string section2, string section3)
        {
            TemplateName = templateName;
            Section1 = section1;
            Section2 = section2;
            Section3 = section3;
        }
    }
}
