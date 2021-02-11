using FlowBlot.Model;
using System;

namespace FlowBlot.Flows
{
    public class Flow_00013
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            Blot blot = new Blot() { Name = String.Empty };
            Color(blot, input);

            /*FLOW:Flow_00013 - A complex pass by reference taint propagation:codethreat.flowblot.benchmark:10:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot.Name);
        }

        public void Color(Blot blot, string input)
        {
            blot.Name = input;
        }
    }
}
