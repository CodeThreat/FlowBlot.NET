namespace FlowBlot.Flows
{
    public class Flow_00027
    {
        public const string ID = "00027"; 
        public const string Description = "A switch taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            string condition = System.Console.ReadLine();

            switch (condition)
            {
                case "one":
                    input = System.String.Empty;
                    break;
                case "two":
                case "three":
                    break;
                default:
                    break;
            }

            System.Diagnostics.Process.Start(input);
        }
    }
}
