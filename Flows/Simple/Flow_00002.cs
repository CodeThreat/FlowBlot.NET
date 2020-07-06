namespace FlowBlot
{
    public class Flow_00002
    {
        public const string ID = "00002";
        public const string Description = "A nested method call source to sink taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            System.Diagnostics.Process.Start(System.Console.ReadLine());
        }
    }
}
