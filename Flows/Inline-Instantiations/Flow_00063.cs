using System.Collections.Generic;

namespace FlowBlot
{
    public class Flow_00063
    {
        public const string ID = "00063";
        public const string Description = "An inline List definition taint propagation";
        public const bool IsVulnerable = true; 

        public void Run()
        {
            string input = System.Console.ReadLine();

            List<string> aList = new List<string>()
            {
                input,
                System.String.Empty,
                System.String.Empty
            };

            System.Diagnostics.Process.Start(aList[0]);
        }
    }
}
