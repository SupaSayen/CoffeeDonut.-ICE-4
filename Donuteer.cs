using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoffeeDonut
{
    class Donuteer
    {
        private short donut;

        public short Donut { get => donut; set => donut = value; }


        public void MakeDonut(Order o)
        {
            MessageBox.Show("Making Donut - " + o.Donut);
        }
    }
}
