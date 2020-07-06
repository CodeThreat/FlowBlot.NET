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

            System.Diagnostics.Process.Start(input);

            new Flow_00026().Run(input);
        }
    }
}
