namespace FlowBlot.Flows
{
    public class Flow_00029
    {
        public const string ID = "00029"; 
        public const string Description = "A ref pass by reference taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.String.Empty;

            Pass(ref input);

            System.Diagnostics.Process.Start(input);
        }

        public void Pass(ref string input)
        {
            input = System.Console.ReadLine();
        }
    }
}
