using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00006
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            List<string> inputs = new List<string>();
            inputs.Add(string.Empty);
            inputs.Add(input);
            inputs.Add(string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00006 - A List item FP taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                FlowBlot.Model.Framework.Sink(inputs[0]);
            }
        }
    }
}
