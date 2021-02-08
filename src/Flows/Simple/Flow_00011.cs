namespace FlowBlot.Flows
{
    public class Flow_00011
    {
        public const string ID = "00011";
        public const string Description = "A return value taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            string colored = Color(input);

            /*FLOW:Flow_00011 - A return value taint propagation:OS Command Injection:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(colored);
        }

        public string Color(string input)
        {
            return input;
        }
    }
}
