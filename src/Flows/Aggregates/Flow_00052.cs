using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00052
    {
        public const string ID = "00052";
        public const string Description = "A SortedList taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            var inputs = new SortedList<string, string>();
            inputs.Add("key", input);
            inputs.Add("key", string.Empty);
            inputs.Add("key", string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00052 - A SortedList taint propagation:OS Command Injection:4:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                System.Diagnostics.Process.Start(inputs["key"]);
            }
        }
    }
}
