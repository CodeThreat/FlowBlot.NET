namespace FlowBlot
{
    public class Flow_00064
    {
        public const string ID = "00064";
        public const string Description = "An inline Array definition taint propagation";
        public const bool IsVulnerable = true; 

        public void Run()
        {
            string input = System.Console.ReadLine();

            string [] anArray = new string []
            {
                input,
                System.String.Empty,
                System.String.Empty
            };

            /*FLOW:Flow_00064 - An inline Array definition taint propagation:OS Command Injection:5:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(anArray[0]);
        }
    }
}
