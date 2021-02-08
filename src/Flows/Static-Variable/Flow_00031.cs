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

            /*FLOW:Flow_00031 - A static variable taint propagation:OS Command Injection:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(medium);
        }
    }
}
