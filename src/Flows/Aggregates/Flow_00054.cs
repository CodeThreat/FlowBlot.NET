using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00054
    {
        public const string ID = "00054";
        public const string Description = "A Queue taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            var inputs = new Queue<string>();
            inputs.Enqueue(input);
            inputs.Enqueue(string.Empty);
            inputs.Enqueue(string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                /*FLOW:Flow_00054 - A Queue taint propagation:OS Command Injection:5:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                System.Diagnostics.Process.Start(inputs.Dequeue());
            }
        }
    }
}
