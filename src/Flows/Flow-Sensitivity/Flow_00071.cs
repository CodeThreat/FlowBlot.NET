namespace FlowBlot.Flows
{
    public class Flow_00071
    {
        public const string ID = "00071"; 
        public const string Description = "A flow-sensitivity vs path-sensitivity FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            int a = 6;
            int b = 5;

            if (a >= b)            
            {
                input = System.String.Empty;
            }

            /*FLOW:Flow_00071 - A flow-sensitivity vs path-sensitivity FP taint propagation:OS Command Injection:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }
    }
}
