namespace FlowBlot.Flows
{
    public class Flow_00024
    {
        public const string ID = "00024"; 
        public const string Description = "A multi source taint propagation";
        public const bool IsVulnerable = true;

        public void Run(string input)
        {
            input += System.Console.ReadLine();

            System.Diagnostics.Process.Start(input);
        }
    }
}
