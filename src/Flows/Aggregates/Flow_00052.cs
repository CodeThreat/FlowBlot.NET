using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00052
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            var inputs = new SortedList<string, string>();
            inputs.Add("key", input);
            inputs.Add("key", string.Empty);
            inputs.Add("key", string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00052 - A SortedList taint propagation:codethreat.flowblot.benchmark:4:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                FlowBlot.Model.Framework.Sink(inputs["key"]);
            }
        }
    }
}
