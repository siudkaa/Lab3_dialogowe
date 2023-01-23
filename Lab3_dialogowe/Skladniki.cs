using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_dialogowe
    {
    public class Ingredient
        {
        public string Name { get; set; }
        public int Price { get; set; }

        public Ingredient(string name, int price)
            {
            Price = price;
            Name = name;
            }

        }
    }
