namespace FlowBlot.Flows
{
    public class Flow_00007
    {
        public const string ID = "00007";
        public const string Description = "A hard-code if taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.String.Empty;
            if (5 > 1)
            {
                input = System.Console.ReadLine();
            }
            System.Diagnostics.Process.Start(input);
        }
    }
}
