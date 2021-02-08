namespace FlowBlot.Flows
{
    public class Flow_00025
    {
        public const string ID = "00025"; 
        public const string Description = "A multi sink taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            /*FLOW:Flow_00025 - A multi sink taint propagation:OS Command Injection:3:FIND_ISSUE:1:
             */
            System.Diagnostics.Process.Start(input);

            new Flow_00026().Run(input);
        }
    }
}
