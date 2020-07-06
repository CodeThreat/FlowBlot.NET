
namespace FlowBlot.Flows
{
    public class Flow_00018
    {
        public const string ID = "00018"; 
        public const string Description = "A deep nested call taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            string input = System.Console.ReadLine();

            string output = Nest(Nest(Nest(Nest(Nest(Nest(Nest(input)))))));

            System.Diagnostics.Process.Start(output);
        }

        public string Nest(string input)
        {
            return input;
        }

    }
}
