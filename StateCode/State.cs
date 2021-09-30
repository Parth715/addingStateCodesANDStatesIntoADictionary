using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCode
{
    class State
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public State(string code, string name)
        {
            Code = code;
            Name = name;
        }

    }
}
