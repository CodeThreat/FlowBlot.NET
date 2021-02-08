using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00058
    {
        public const string ID = "00058";
        public const string Description = "An interface based alias analysis taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            A a = new A();
            a.b = input;

            G g = new H();
            A b = g.Id(a);

            /*FLOW:Flow_00058 - An interface based alias analysis taint propagation:OS Command Injection:9:FIND_ISSUE:1:
              *STEP_PATH:ABC
              */
            System.Diagnostics.Process.Start(b.b);
        }
    }
}
