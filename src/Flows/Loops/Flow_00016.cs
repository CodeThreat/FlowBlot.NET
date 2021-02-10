using System;

namespace FlowBlot.Flows
{
    public class Flow_00016
    {
        public void Run()
        {
            int x = 10;
            int y = 2;

            string input = String.Empty;

            while(x > y)
            {
                input = FlowBlot.Model.Framework.Source();
                y++;
            }

            /*FLOW:Flow_00016 - A loop taint propagation:codethreat.flowblot.benchmark:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(input);
        }

    }
}
