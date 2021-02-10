using System.Collections;

namespace FlowBlot
{
    public class Flow_00049
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            ArrayList inputs = new ArrayList();
            inputs.Add(input);
            inputs.Add(string.Empty);
            inputs.Add(string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00049 - An ArrayList taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                FlowBlot.Model.Framework.Sink(inputs[0].ToString());
            }
        }
    }
}
