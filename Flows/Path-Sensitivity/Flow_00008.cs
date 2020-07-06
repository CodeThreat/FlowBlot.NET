namespace FlowBlot.Flows
{
    public class Flow_00008
    {
        public const string ID = "00008";
        public const string Description = "A hard-coded if FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();            
            if (5 > 1)
            {
                input = System.String.Empty;
            }
            System.Diagnostics.Process.Start(input);
        }
    }
}
