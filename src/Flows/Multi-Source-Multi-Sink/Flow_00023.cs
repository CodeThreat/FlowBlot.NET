namespace FlowBlot.Flows
{
    public class Flow_00023
    {
        public const string ID = "00023"; 
        public const string Description = "A multi source taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            /*FLOW:Flow_00023 - A multi source taint propagation:OS Command Injection:0:NONE:0:
             *STEP_PATH:ABC
             */
            new Flow_00024().Run(input);
        }
    }
}
