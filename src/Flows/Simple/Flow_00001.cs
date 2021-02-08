namespace FlowBlot.Flows
{
    public class Flow_00001
    {
        public const string ID = "00001";
        public const string Description = "A Basic source to sink taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            /*FLOW:Flow_00001 - A Basic source to sink taint propagation:OS Command Injection:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }
    }
}
