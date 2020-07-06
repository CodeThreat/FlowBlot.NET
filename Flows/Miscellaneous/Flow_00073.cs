using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00073
    {
        public const string ID = "00073";
        public const string Description = "A more complex 3rd-party code taint propagation";
        public const bool IsVulnerable = true; // a step towards soundness. not precise. trust level matters: medium|low

        public void Run()
        {
            string input = System.Console.ReadLine();

            IShoppingCart cart = ShoppingCartFactory.FetchCart();

            IItem milk = ItemFactory.FetchMilk();
            milk.SetName(input);

            cart.PutItem(milk);

            IItem anItem = cart.FetchItem(0);

            System.Diagnostics.Process.Start(anItem.GetName());
        }
    }
}
