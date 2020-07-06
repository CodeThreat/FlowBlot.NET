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

            System.Diagnostics.Process.Start(input);
        }

    }
}
