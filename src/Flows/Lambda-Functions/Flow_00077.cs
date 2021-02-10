using FlowBlot.Model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FlowBlot
{
    public class Flow_00077
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            Func<string, string> myFunc = x => x == "Formal" ? "Welcome" : "Howdy";

            string output = myFunc(input);

            /*FLOW:Flow_00077 - An expression lambda FP taint propagation:codethreat.flowblot.benchmark:6:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            FlowBlot.Model.Framework.Sink(output);
        }
    }
}
