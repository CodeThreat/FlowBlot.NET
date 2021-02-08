using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBlot.Model
{
    public interface IShoppingCart
    {
        bool PutItem(IItem item);
        IItem FetchItem(int index);
    }

    public class ShoppingCartFactory
    {
        public static IShoppingCart FetchCart()
        {
            return (IShoppingCart)new Object();
        }
    }

    public interface IItem
    {
        void SetName(string name);

        string GetName();
    }

    public class ItemFactory
    {
        public static IItem FetchMilk()
        {
            return (IItem)new Object();
        }
        public static IItem FetchBread()
        {
            return (IItem)new Object();
        }
    }
}
