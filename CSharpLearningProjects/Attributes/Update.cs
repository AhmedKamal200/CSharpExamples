using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [DebuggerDisplay("No:{no},Title: {title}")]
     class Update
    {
        private int no;
        private string title;

        public Update(int number,string name)
        {
            this.no = number;
            this.title = name;

        }
        public override string ToString()
        {
            return $"{no} - {title}";
        }
    }
}
