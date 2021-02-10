using FlowBlot.Model;

namespace FlowBlot.Flows
{
    public class Flow_00073
    {
        // a step towards soundness. not precise. trust level matters: medium|low

        public void Run()
        {
            string input = FlowBlot.Model.Framework.Source();

            IShoppingCart cart = ShoppingCartFactory.FetchCart();

            IItem milk = ItemFactory.FetchMilk();
            milk.SetName(input);

            cart.PutItem(milk);

            IItem anItem = cart.FetchItem(0);

            /*FLOW:Flow_00073 - A more complex 3rd-party code taint propagation:codethreat.flowblot.benchmark:0+:FIND_ISSUE:1:
             *STEP_PATH:ABC
             */
            FlowBlot.Model.Framework.Sink(anItem.GetName());
        }
    }
}
