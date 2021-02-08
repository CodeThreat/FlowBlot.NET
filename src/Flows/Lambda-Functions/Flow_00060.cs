using FlowBlot.Model;

namespace FlowBlot
{
    public class Flow_00060
    {
        public const string ID = "00060";
        public const string Description = "A delegate taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            MProxy proxy = new MProxy();
            MProxy.Fetch fetchDelegate = new MProxy.Fetch(proxy.FetchPropagate);
            string output = fetchDelegate(input);

            /*FLOW:Flow_00060:OS Command Injection:7:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            System.Diagnostics.Process.Start(output);
        }


    }
}
