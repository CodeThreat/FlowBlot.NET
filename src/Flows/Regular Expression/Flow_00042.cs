using System.Text.RegularExpressions;

namespace FlowBlot.Flows
{
    public class Flow_00042
    {
        // kinda false, looking at the regex itself
        // but still there's a possibility of a vulnerability

        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            Match match = Regex.Match(input, @"([\d+])");

            if(match.Success)
            {

                /*FLOW:Flow_00042 - A regular expression taint propagation:codethreat.flowblot.benchmark:7:FIND_ISSUE:1:
                 *STEP_PATH:ABC
                 */
                FlowBlot.Model.Framework.Sink(match.Groups[1].Value);
            }
        }

    }
}
