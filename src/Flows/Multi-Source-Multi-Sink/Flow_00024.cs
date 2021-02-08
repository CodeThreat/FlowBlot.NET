namespace FlowBlot.Flows
{
    public class Flow_00024
    {
        public const string ID = "00024";
        public const string Description = "A multi source taint propagation";
        public const bool IsVulnerable = true;

        public void Run(string input)
        {
            input += System.Console.ReadLine();


            /*FLOW:Flow_00024 - A multi source taint propagation:OS Command Injection:3:FIND_ISSUE:1:2:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }
    }
}
