using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoffeeDonut
{
    class Barista
    {
        private short coffee;

        public short Coffee { get => coffee; set => coffee = value; }


        public void MakeCoffee(Order o)
        {
            //double totCoffee = coffee * coffeePrice;
            MessageBox.Show("Making Coffee - " + o.Coffee);
        }
    }
}
