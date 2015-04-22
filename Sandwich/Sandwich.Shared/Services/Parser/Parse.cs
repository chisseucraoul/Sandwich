using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sandwich.Services.Parser
{
    public class Parse
    {

        public Parse() { }

        //boisson/sandwich/ingredient/commande

        public List<Drinks> ParseDrink(string json)
        {
            List<Drinks> drink = JsonConvert.DeserializeObject<List<Drinks>>(json);

            return drink;
        }






    }
}
