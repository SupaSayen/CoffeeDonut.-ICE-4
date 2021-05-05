using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDonut
{
    class ProcessOrder
    {
        public delegate void ProcessOrderDelegate(Order o);

        public event ProcessOrderDelegate OrderPlaced;

        public void ProcessOrders(Order o)
        {
            Donuteer d = new Donuteer();
            Barista b = new Barista();
            Payment p = new Payment();

            OrderPlaced += d.MakeDonut;
            OrderPlaced += b.MakeCoffee;
            OrderPlaced += p.CollectPayment;

            OrderSubmitted(o);
        }

        protected virtual void OrderSubmitted(Order o)
        {
            if (OrderPlaced != null)
            {
                OrderPlaced(o);
            }
        }
    }
}
