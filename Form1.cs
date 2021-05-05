using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeDonut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int donuts = Convert.ToInt32(numbDonuts.Value);
            int coffee = Convert.ToInt32(numbCoffee.Value);

            Order o = new Order(name, donuts, coffee);

            ProcessOrder p = new ProcessOrder();
            p.ProcessOrders(o);

        }
    }
}
