using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00053
    {
        public const string ID = "00053";
        public const string Description = "A SortedDictionary taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            var inputs = new SortedDictionary<string, string>();
            inputs.Add("key", input);
            inputs.Add("key", string.Empty);
            inputs.Add("key", string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00053 - A SortedDictionary taint propagation:OS Command Injection:4:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                System.Diagnostics.Process.Start(inputs["key"]);
            }
        }
    }
}
