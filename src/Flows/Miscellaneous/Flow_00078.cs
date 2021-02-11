using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlowBlot.Flows
{
    public class Flow_00078
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            string output = input.TrimAndReturn();

            /*FLOW:Flow_00078 - An extension method taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            FlowBlot.Model.Framework.Sink(output);
        }
    }

    public static class StringExtension
    {
        public static string TrimAndReturn(this string str)
        {
            return str.Trim();
        }
    }
}
