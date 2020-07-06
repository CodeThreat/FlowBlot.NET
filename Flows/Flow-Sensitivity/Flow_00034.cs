namespace FlowBlot.Flows
{
    public class Flow_00034
    {
        public const string ID = "00034"; 
        public const string Description = "A flow-sensitive FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            input = System.String.Empty;

            System.Diagnostics.Process.Start(input);
        }
    }
}
