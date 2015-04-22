using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwich
{
    public class Foods
    {

        private string foodID;

        public string FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        private string nameFood;

        public string NameFood
        {
            get { return nameFood; }
            set { nameFood = value; }
        }

        private float priceFood;

        public float PriceFood
        {
            get { return priceFood; }
            set { priceFood = value; }
        }

        private string descriptionFood;

        public string DescriptionFood
        {
            get { return descriptionFood; }
            set { descriptionFood = value; }
        }

        private string imageUrlFood;

        public string ImageUrlFood
        {
            get { return imageUrlFood; }
            set { imageUrlFood = value; }
        }
    }
}
