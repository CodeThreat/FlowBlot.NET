namespace FlowBlot.Flows
{
    public class Flow_00040
    {
        public const string ID = "00040"; 
        public const string Description = "An unreachable taint flow";
        public const bool IsVulnerable = true;

        public void Run()
        {
            float x = 5.0f;
            if(x > 6.5f)
            {
                string input = System.String.Empty;
            }
        }

        private void NeverCalled()
        {
            string input = System.Console.ReadLine();
            System.Diagnostics.Process.Start(input);
        }
    }
}
