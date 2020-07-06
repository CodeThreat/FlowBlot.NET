namespace FlowBlot.Flows
{
    public class Flow_00037
    {
        public const string ID = "00037"; 
        public const string Description = "An exception handler taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            try
            {
                input = input.Substring(1, 5);
            }
            catch(System.Exception e)
            {
                System.Diagnostics.Process.Start(input);
            }
        }
    }
}
