using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Tech.BAL
{
    class Code
    {
        public string CodeTitle { get; set; }
        public string CodeBody { get; set; }

        public Code(string codeTitle, string codeBody)
        {
            CodeTitle = codeTitle;
            CodeBody = codeBody;
        }
    }
}
