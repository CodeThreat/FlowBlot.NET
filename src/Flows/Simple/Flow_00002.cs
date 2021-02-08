namespace FlowBlot
{
    public class Flow_00002
    {
        public const string ID = "00002";
        public const string Description = "A nested method call source to sink taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            /*FLOW:Flow_00002 - A nested method call source to sink taint propagation:OS Command Injection:1:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(System.Console.ReadLine());
        }
    }
}
