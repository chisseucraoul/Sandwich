using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using Windows.Data.Json;
using Sandwich.DataModel;
using System.Linq;


namespace Sandwich.Services.DataProvider
{
    public class ProvideData
    {
        public HttpClient Request { get; set; }

        public ProvideData()
        {
            // TODO: Complete member initialization
            Request = new HttpClient();
            Request.DefaultRequestHeaders.Add("X-Parse-Application-Id", "EBJy7sR5IbWEYU3aLndx2ps10LL8ycT4RuGx87XK");
            Request.DefaultRequestHeaders.Add("X-Parse-REST-API-Key", "hQtoDMxepJJmQ12RvQ84e4N2agQNbyPTetyj1afW");
        }



        public async Task<IList<Drinks>> getlstDrinksAsync()
        {
           

                // Fetch a response from the server. This will give us back error codes or a successful code

                var response = await Request.GetStringAsync(new Uri("https://api.parse.com/1/classes/Drinks", UriKind.RelativeOrAbsolute));
               

                var rawdrink = JObject.Parse(response);

                // get JSON result objects into a list

                IList<JToken> results = rawdrink["results"].Children().ToList();

                // serialize JSON results into .NET objects
                IList<Drinks> lstDrinks = new List<Drinks>();
                foreach (JToken result in results)
                {
                    try
                    {
                        Drinks searchResult =  new Drinks
                        {
                            FrenchName = result["FrenchName"].ToString(),
                            Image = result["Image"]["url"].ToString(),
                            ObjectId = result["objectId"].ToString(),
                            Price = result["Price"].Value<float>(),

                        };
                        lstDrinks.Add(searchResult);
                    }
                    catch (Exception all)
                    {
                        Debug.WriteLine("Invalid Drink object");
                    }
                   
                }

                Request.Dispose(); //free the ressource


                return lstDrinks;
            }

          public async Task<IList<Sandwich.DataModel.Sandwich>> getlstSandwichAsync()
        {
           

                // Fetch a response from the server. This will give us back error codes or a successful code

                var response = await Request.GetStringAsync(new Uri("https://api.parse.com/1/classes/Sandwichs", UriKind.RelativeOrAbsolute));
               

                var rawsandwich = JObject.Parse(response);

                // get JSON result objects into a list

                IList<JToken> results = rawsandwich["results"].Children().ToList();

                // serialize JSON results into .NET objects
                IList<Sandwich.DataModel.Sandwich> lstSandwichs = new List<Sandwich.DataModel.Sandwich>();
                foreach (JToken result in results)
                {
                    try
                    {
                        Sandwich.DataModel.Sandwich searchResult = new Sandwich.DataModel.Sandwich

                        
                        {
                            FrenchName = result["FrenchName"].ToString(),
                            Image = result["Image"]["url"].ToString(),
                            ObjectId = result["objectId"].ToString(),
                            Price = result["Price"].Value<float>(),

                        };

                        
                        searchResult.Bread = null;
                        searchResult.Crudite = false;

                        lstSandwichs.Add(searchResult);
                    }
                    catch (Exception all)
                    {
                        Debug.WriteLine("Invalid Sandwich object");
                    }
                   
                }

                Request.Dispose(); //free the ressource


                return lstSandwichs;
            }
         
        public async Task<IList<Ingredient>> getlstIngredientAsync()
        {
           

                // Fetch a response from the server. This will give us back error codes or a successful code

                var response = await Request.GetStringAsync(new Uri("https://api.parse.com/1/classes/Ingredients", UriKind.RelativeOrAbsolute));
               

                var rawingredient = JObject.Parse(response);

                // get JSON result objects into a list

                IList<JToken> results = rawingredient["results"].Children().ToList();

                // serialize JSON results into .NET objects
                IList<Ingredient> lstIngredients = new List<Ingredient>();

                foreach (JToken result in results)
                {
                    try
                    {
                        Ingredient searchResult =  new Ingredient

                        
                        {
                            FrenchName = result["FrenchName"].ToString(),
                            ObjectId = result["objectId"].ToString(),

                        };

                      

                        lstIngredients.Add(searchResult);
                    }
                    catch (Exception all)
                    {
                        Debug.WriteLine("Invalid Ingredient object");
                    }
                   
                }

                Request.Dispose(); //free the ressource


                return lstIngredients;
            }
         

         


        }


    
}
