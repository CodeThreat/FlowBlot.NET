namespace FlowBlot.Flows
{
    public class Flow_00030
    {
        public const string ID = "00030"; 
        public const string Description = "An out pass by reference taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input;

            Pass(out input);


            /*FLOW:Flow_00030 - An out pass by reference taint propagation:OS Command Injection:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }

        public void Pass(out string input)
        {
            input = System.Console.ReadLine();
        }
    }
}
