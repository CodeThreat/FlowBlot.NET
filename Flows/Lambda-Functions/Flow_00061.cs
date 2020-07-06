using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00061
    {
        public const string ID = "00061";
        public const string Description = "A delegate FP taint propagation";
        public const bool IsVulnerable = false;

        public void Run()
        {
            string input = System.Console.ReadLine();

            MProxy proxy = new MProxy();
            MProxy.Fetch fetchDelegate = new MProxy.Fetch(proxy.FetchNoPropagate);
            string output = fetchDelegate(input);
            System.Diagnostics.Process.Start(output);
        }
    }
}
