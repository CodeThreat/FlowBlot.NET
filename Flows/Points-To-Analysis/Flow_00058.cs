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

            System.Diagnostics.Process.Start(b.b);
        }
    }
}
