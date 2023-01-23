using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_dialogowe
    {
    public partial class MainWindow
        {
        public class Pizza
            {
            public string Dough { get; set; } //ciasto
            public string Type { get; set; } //typ pizzy, rodzaj pizzy
            public string ExtraIngredient { get; set; } //dodatkowy skladnik
            public string Sauce { get; set; } //sos
            public string Size { get; set; } //rozmiar
            public Pizza() { }
            public Pizza(string dough, string type, string sauce, string size)
                {
                Dough = dough;
                Type = type;
                Sauce = sauce;
                Size = size;
                }

            }

        }
    }
