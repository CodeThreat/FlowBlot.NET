using System.Collections;

namespace FlowBlot
{
    public class Flow_00050
    {
        public const string ID = "00050";
        public const string Description = "A HashTable taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            Hashtable inputs = new Hashtable();
            inputs.Add("key", input);
            inputs.Add("key1",string.Empty);
            inputs.Add("key2", string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00050 - A HashTable taint propagation:OS Command Injection:5:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                System.Diagnostics.Process.Start(inputs["key"].ToString());
            }
        }
    }
}
