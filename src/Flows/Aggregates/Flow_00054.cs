using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00054
    {
       public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            var inputs = new Queue<string>();
            inputs.Enqueue(input);
            inputs.Enqueue(string.Empty);
            inputs.Enqueue(string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00054 - A Queue taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                FlowBlot.Model.Framework.Sink(inputs.Dequeue());
            }
        }
    }
}
