
namespace FlowBlot.Flows
{
    public class Flow_00026
    {
        public const string ID = "00026"; 
        public const string Description = "A multi sink taint propagation";
        public const bool IsVulnerable = true;

        public void Run(string input)
        {
            System.Diagnostics.Process.Start(input);
        }
    }
}
