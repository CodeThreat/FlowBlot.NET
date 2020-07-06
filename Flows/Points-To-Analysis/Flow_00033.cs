using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00033
    {
        public const string ID = "00033"; 
        public const string Description = "A context-sensitive points-to analysis taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {

            string input1 = System.String.Empty;

            DataSource ds1 = new DataSource(input1);

            string input2 = System.Console.ReadLine();

            DataSource ds2 = new DataSource(input2);

            string output1 = ds1.getUrl();

            string output2 = ds2.getUrl();

            System.Diagnostics.Process.Start(output2);
        }
    }
}
