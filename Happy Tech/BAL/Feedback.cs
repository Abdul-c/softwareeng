using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Tech.BAL
{
    class Feedback
    {
        public string Name { get; set; }
        public string Eamil { get; set; }
        public string Template { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }

        public Feedback(string name, string eamil, string template, string code, string text)
        {
            Name = name;
            Eamil = eamil;
            Template = template;
            Code = code;
            Text = text;
        }
    }
}
