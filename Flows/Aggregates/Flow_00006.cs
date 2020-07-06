using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00006
    {
        public const string ID = "00006";
        public const string Description = "A List item FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();
            List<string> inputs = new List<string>();
            inputs.Add(string.Empty);
            inputs.Add(input);
            inputs.Add(string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                System.Diagnostics.Process.Start(inputs[0]);
            }
        }
    }
}
