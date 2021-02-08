namespace FlowBlot.Flows
{
    public class Flow_00081
    {
        public const string ID = "00081";
        public const string Description = "A dynamic number of arguments method call";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();            
            RunMe(string.Empty, input, null, null);
        }

        private void RunMe(string one, params string[] arguments)
        {
            if (arguments != null)
            {
                /*FLOW:Flow_00081 - A dynamic number of arguments method call:OS Command Injection:5:FIND_ISSUE:1:
                    *STEP_PATH:ABC
                    */
                System.Diagnostics.Process.Start(arguments[0]);
            }
        }
    }
}
