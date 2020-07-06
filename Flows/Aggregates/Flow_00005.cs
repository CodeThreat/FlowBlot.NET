using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00005
    {
        public const string ID = "00005";
        public const string Description = "A List item taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            List<string> inputs = new List<string>();
            inputs.Add(input);
            inputs.Add(string.Empty);
            inputs.Add(string.Empty);
            if (inputs != null && inputs.Count > 0)
            {
                System.Diagnostics.Process.Start(inputs[0]);
            }
        }
    }
}
