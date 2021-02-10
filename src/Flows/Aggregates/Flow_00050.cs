using System.Collections;

namespace FlowBlot
{
    public class Flow_00050
    {
        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();
            Hashtable inputs = new Hashtable();
            inputs.Add("key", input);
            inputs.Add("key1",string.Empty);
            inputs.Add("key2", string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00050 - A HashTable taint propagation:codethreat.flowblot.benchmark:5:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                FlowBlot.Model.Framework.Sink(inputs["key"].ToString());
            }
        }
    }
}
