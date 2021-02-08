namespace FlowBlot.Flows
{
    public class Flow_00034
    {
        public const string ID = "00034"; 
        public const string Description = "A flow-sensitive FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            input = System.String.Empty;


            /*FLOW:Flow_00034 - A flow-sensitive FP taint propagation:OS Command Injection:4:FIND_ISSUE:1:
            *STEP_PATH:ABC
            */
            System.Diagnostics.Process.Start(input);
        }
    }
}
