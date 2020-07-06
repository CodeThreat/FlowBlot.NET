using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBlot.Model
{
    public class MProxy
    {
        public delegate string Fetch(string input);

        public string FetchPropagate(string input)
        {
            return input;   
        }

        public string FetchNoPropagate(string input)
        {
            return String.Empty;
        }
    }
}
