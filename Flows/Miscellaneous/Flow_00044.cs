namespace FlowBlot.Flows
{
    public class Flow_00044
    {
        public const string ID = "00044"; 
        public const string Description = "A source to sink complex trace order";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();
            Method1(input);
        }

        public void Method1(string input)
        {            
            if (5 > 1)
            {
                Method2(input);
            }

            System.Diagnostics.Process.Start(input);
        }

        public void Method2(string input)
        {
            input = input.Substring(5);
        }
    }
}
