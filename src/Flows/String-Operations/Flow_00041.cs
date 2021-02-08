namespace FlowBlot.Flows
{
    public class Flow_00041
    {
        public const string ID = "00041"; 
        public const string Description = "A string format taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = "Name: {0}";
            string output = System.String.Format(input, System.Console.ReadLine());

            /*CTSECISSUE:Flow_00041 - A string format taint propagation:OS Command Injection:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(output);
        }

    }
}
