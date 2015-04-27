using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace Sandwich.Services.Parser
{
    public class ParseObject
    {

        public ParseObject() { }


        public List<Drinks> ParseDrink(string json)
        {
            List<Drinks> drink = JsonConvert.DeserializeObject<List<Drinks>>(json);

            return drink;
        }

        public List<Sandwich> ParseSandwich(string json)
        {
            List<Sandwich> sandwich = JsonConvert.DeserializeObject<List<Sandwich>>(json);

            return sandwich;
        }

        public List<Ingredient> ParseIngredient(string json)
        {
            List<Ingredient> ingredient = JsonConvert.DeserializeObject<List<Ingredient>>(json);

            return ingredient;
        }








    }
}
