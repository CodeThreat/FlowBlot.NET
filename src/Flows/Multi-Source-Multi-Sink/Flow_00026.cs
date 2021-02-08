
namespace FlowBlot.Flows
{
    public class Flow_00026
    {
        public const string ID = "00026"; 
        public const string Description = "A multi sink taint propagation";
        public const bool IsVulnerable = true;

        public void Run(string input)
        {

            /*FLOW:Flow_00026 - A multi sink taint propagation:OS Command Injection:6:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }
    }
}
