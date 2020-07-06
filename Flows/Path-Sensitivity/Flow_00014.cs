namespace FlowBlot.Flows
{
    public class Flow_00014
    {
        public const string ID = "00014"; 
        public const string Description = "A complex if taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            int x = 1;
            int y = 2;

            string input2 = System.String.Empty;
            string input = System.String.Empty;

            if(x > y)
            {
                input = "Default";
            }
            else
            {
                input = System.Console.ReadLine();
            }

            input2 = input;

            System.Diagnostics.Process.Start(input2);
        }

    }
}
