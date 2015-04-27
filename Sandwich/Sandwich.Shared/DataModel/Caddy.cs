using Sandwich.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwich
{
    public sealed class Caddy
    {


        private static readonly Caddy instance = new Caddy();

        private Caddy()
        {
            FoodQtyDictionary = new Dictionary<Foods, int>();
        }

        public static Caddy Instance
        {
            get
            {
                return instance;
            }
        }

        public Dictionary<Foods, int> FoodQtyDictionary { get; set; }
        
        
        public void CleanCaddy()
        {
            FoodQtyDictionary.Clear();
        }

        public void addCaddy(Foods newFood, int qty)
        {

            if (this.FoodQtyDictionary.ContainsKey(newFood))
            {
                int oldval = this.FoodQtyDictionary[newFood];

                this.FoodQtyDictionary.Remove(newFood);
                this.FoodQtyDictionary.Add(newFood, oldval + qty);
            }
            else
            {
                FoodQtyDictionary.Add(newFood, qty);
            }

        }
        public void deleteFoodCaddy(Foods deletedFood)
        {
            if (this.FoodQtyDictionary.Count != 0)
            {
                if (this.FoodQtyDictionary.ContainsKey(deletedFood))
                {

                }
            }

        }
    }
}
