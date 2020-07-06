namespace FlowBlot.Flows
{
    public class Flow_00028
    {
        public const string ID = "00028"; 
        public const string Description = "A integer cast taint propagation";
        public const bool IsVulnerable = true; // maybe not string injection, but still with a low TrustLevel 
                                                // same with the Process.Start arguments parameter

        public void Run()
        {
            string input = System.Console.ReadLine();

            int output = System.Int32.Parse(input);

            System.Diagnostics.Process.Start(output.ToString());
        }
    }
}
