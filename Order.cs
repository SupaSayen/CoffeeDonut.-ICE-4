using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeDonut
{
    public class Order
    {
        private string name;
        private int donut;
        private int coffee;

        public Order(string name, int donut, int coffee)
        {
            this.name = name;
            this.donut = donut;
            this.coffee = coffee;
        }

        public int Donut { get => donut; set => donut = value; }
        public int Coffee { get => coffee; set => coffee = value; }
        public string Name { get => name; set => name = value; }
    }
}
