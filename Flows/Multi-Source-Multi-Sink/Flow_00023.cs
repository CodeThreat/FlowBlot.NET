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

            new Flow_00024().Run(input);
        }
    }
}
