namespace FlowBlot.Flows
{
    public class Flow_00037
    {
        public const string ID = "00037"; 
        public const string Description = "An exception handler taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            try
            {
                input = input.Substring(1, 5);
            }
            catch(System.Exception e)
            {
                /*FLOW:Flow_00037 - An exception handler taint propagation:OS Command Injection:4:FIND_ISSUE:1:
                *STEP_PATH:ABC
                */
                System.Diagnostics.Process.Start(input);
            }
        }
    }
}
