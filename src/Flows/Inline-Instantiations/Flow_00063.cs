using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00063
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            List<string> aList = new List<string>()
            {
                input,
                System.String.Empty,
                System.String.Empty
            };

            /*FLOW:Flow_00063 - An inline List definition taint propagation:codethreat.flowblot.benchmark:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(aList[0]);
        }
    }
}
