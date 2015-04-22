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
            foodQtydictionary = new Dictionary<Foods, int>();
        }

        public static Caddy Instance
        {
            get
            {
                return instance;
            }
        }

        private Dictionary<Foods, int> foodQtydictionary;

        public Dictionary<Foods, int> FoodQtydictionary
        {
            get { return foodQtydictionary; }
            set { foodQtydictionary = value; }
        }
        //ceci est u comm
        public void CleanCaddy()
        {
            FoodQtydictionary.Clear();
        }

        public void addCaddy(Foods newFood, int qty)
        {

            if (this.FoodQtydictionary.ContainsKey(newFood))
            {
                int oldval = this.FoodQtydictionary[newFood];

                this.FoodQtydictionary.Remove(newFood);
                this.FoodQtydictionary.Add(newFood, oldval + qty);


            }
            else
            {

                FoodQtydictionary.Add(newFood, qty);


            }




        }
        public void deleteFoodCaddy(Foods deletedFood)
        {
            if (this.FoodQtydictionary.Count != 0)
            {
                if (this.FoodQtydictionary.ContainsKey(deletedFood))
                {

                }
            }

        }
    }
}
