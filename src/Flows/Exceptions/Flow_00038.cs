namespace FlowBlot.Flows
{
    public class Flow_00038
    {
        public const string ID = "00038"; 
        public const string Description = "An exception message taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            try
            {
                ThrowThat();
            }
            catch(System.Exception e)
            {
              /*FLOW:Flow_00038 - An exception handler taint propagation:OS Command Injection:0+:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
                System.Diagnostics.Process.Start(e.Message);
            }
        }

        public void ThrowThat()
        {
            string input = System.Console.ReadLine();

            throw new System.Exception(input);
        }

    }
}
