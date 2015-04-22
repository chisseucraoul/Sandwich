using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwich
{
    public class Foods
    {
        public String FoodID { get; set; }
        public String NameFood { get; set; }

        public float PriceFood { get; set; }
       

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
