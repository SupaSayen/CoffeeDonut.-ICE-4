using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace CoffeeDonut
{
    class Payment
    {

        private const double donutPrice = 5.50;
        private const double coffeePrice = 12.50;
        
        public void CollectPayment(Order o)
        {
             double donutAmt = o.Donut * donutPrice;
             double coffeeAmt = o.Coffee * coffeePrice;
             MessageBox.Show("Collecting payment from: " + o.Name +
                 "\nAmount for donuts : " + donutAmt.ToString("C", CultureInfo.CurrentCulture) +
                 "\nAmount for coffee : " + coffeeAmt.ToString("C", CultureInfo.CurrentCulture));
        }
    }
}
