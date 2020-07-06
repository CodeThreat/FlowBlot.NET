using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00022
    {
        public const string ID = "00022"; 
        public const string Description = "A inter-procedural polymorphic taint propagation";
        public const bool IsVulnerable = true;

        public void Run()
        {
            Atlas atlas = new Atlas();
            atlas.name = System.Console.ReadLine();

            Machine machine = Build(atlas);

            string input = ((Atlas)machine).SayName();

            System.Diagnostics.Process.Start(input);
        }

        public Machine Build(Machine machine)
        {
            return machine;
        }

    }
}
