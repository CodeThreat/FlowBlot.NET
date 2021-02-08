
namespace FlowBlot.Flows
{
    public class Flow_00017
    {
        public const string ID = "00017"; 
        public const string Description = "A recursive taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = Sprinkle(System.Console.ReadLine());

            /*FLOW:Flow_00017 - A recursive taint propagation:OS Command Injection:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }

        public string Sprinkle(string input)
        {
            string output = input + "s";

            if (output.Length < 1000)
            {
                output = Sprinkle(output);
            }

            return output;
        }

    }
}
