using FlowBlot.Model;
using System;

namespace FlowBlot.Flows
{
    public class Flow_00019
    {
        public void Run()
        {
            Blot blot = new Blot();
            blot.Label = String.Empty;


            /*FLOW:Flow_00019 - A setter taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(blot.Label);
        }

    }
}
