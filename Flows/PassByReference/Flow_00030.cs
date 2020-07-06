namespace FlowBlot.Flows
{
    public class Flow_00030
    {
        public const string ID = "00030"; 
        public const string Description = "An out pass by reference taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input;

            Pass(out input);

            System.Diagnostics.Process.Start(input);
        }

        public void Pass(out string input)
        {
            input = System.Console.ReadLine();
        }
    }
}
