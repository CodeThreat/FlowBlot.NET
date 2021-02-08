namespace FlowBlot.Flows
{
    public class Flow_00070
    {
        public const string ID = "00070"; 
        public const string Description = "A flow-sensitivity vs path-sensitivity taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            int a = 1;
            int b = 5;

            if (a >= b)            
            {
                input = System.String.Empty;
            }

            /*FLOW:Flow_00070 - A flow-sensitivity vs path-sensitivity taint propagation:OS Command Injection:4:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }
    }
}
