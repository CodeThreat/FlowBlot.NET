namespace FlowBlot.Flows
{
    public class Flow_00080
    {
        public const string ID = "00080";
        public const string Description = "A named argument method call";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            RunMe(arg: input, one: string.Empty);
        }

        private void RunMe(string one, string arg)
        {

            /*FLOW:Flow_00080 - A named argument method call:OS Command Injection:0+:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(arg);
        }
    }
}
