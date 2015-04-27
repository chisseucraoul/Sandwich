using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.IO;
using Sandwich.Services.Parser;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using Windows.Data.Json;



namespace Sandwich.Services.DataProvider
{
    public  class ProvideData
    {
        public HttpClient Request { get; set; }

        public ProvideData()
        {
            // TODO: Complete member initialization
            Request = new HttpClient();
        }



        public async Task<IList<Foods>> getlstDrinksAsync()
        {

            // Next set up our request URL, headers Content Type.
           /* Request = System.Net.HttpWebRequest.CreateHttp(new Uri("https://api.parse.com/1/Drinks"));
            Request.Headers["X-Parse-Application-Id"] = "EBJy7sR5IbWEYU3aLndx2ps10LL8ycT4RuGx87XK";
            Request.Headers["X-Parse-Windows-Key"] = "gPe29yqyMN5pFbi5vK2HgGhyRBIA0VbYuI4dShCC";
            Request.Method = "GET";
            Request.ContentType = "application/json";*/

            
           
            // Fetch a response from the server. This will give us back error codes or a successful code
            var response = await Request.GetStringAsync(new Uri("https://EBJy7sR5IbWEYU3aLndx2ps10LL8ycT4RuGx87XK:REST-API-key=hQtoDMxepJJmQ12RvQ84e4N2agQNbyPTetyj1afW@api.parse.com/1/classes/Drinks"));
           // string resultJson = string.Empty;

            // Convert Read the Json response in to a string
           /* using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                resultJson = streamReader.ReadToEnd();
            }*/
            
            var rawdrink = JObject.Parse(response);

           // get JSON result objects into a list
            IList<JToken> results = (List<JToken>)rawdrink.SelectTokens("results").Children();
                
                
                
            /*    ["results"].Children().ToList();*/

            // serialize JSON results into .NET objects
            IList<Foods> lstDrinks = new List<Foods>();
            foreach (JToken result in results)
            {
                
                Foods searchResult = JsonConvert.DeserializeObject<Foods>(result.ToString());
                lstDrinks.Add(searchResult);
            }

            Request.Dispose(); //free the ressource

           return lstDrinks;


        }







    }
}
