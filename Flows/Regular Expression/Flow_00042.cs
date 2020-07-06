using System.Text.RegularExpressions;

namespace FlowBlot.Flows
{
    public class Flow_00042
    {
        public const string ID = "00042"; 
        public const string Description = "A regular expression taint propagation";
        public const bool IsVulnerable = true; // kinda false, looking at the regex itself
                                                // but still there's a possibility of a vulnerability

        public void Run()
        {
            string input = System.Console.ReadLine();

            Match match = Regex.Match(input, @"([\d+])");

            if(match.Success)
            {
                System.Diagnostics.Process.Start(match.Groups[1].Value);
            }
        }

    }
}
