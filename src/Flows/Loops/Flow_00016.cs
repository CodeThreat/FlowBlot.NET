using System;

namespace FlowBlot.Flows
{
    public class Flow_00016
    {
        public const string ID = "00016"; 
        public const string Description = "A loop taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            int x = 10;
            int y = 2;

            string input = String.Empty;

            while(x > y)
            {
                input = System.Console.ReadLine();
                y++;
            }

            /*FLOW:Flow_00016 - A loop taint propagation:OS Command Injection:3:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(input);
        }

    }
}
