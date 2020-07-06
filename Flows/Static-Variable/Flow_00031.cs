namespace FlowBlot.Flows
{
    public class Flow_00031
    {
        public const string ID = "00031"; 
        public const string Description = "A static variable taint propagation";
        public const bool IsVulnerable = true;

        public static string medium = System.String.Empty;

        public void Run()
        {
            string input = System.Console.ReadLine();

            medium = input;

            System.Diagnostics.Process.Start(medium);
        }
    }
}
