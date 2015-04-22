using System;
using System.Collections.Generic;
using System.Text;
using System.Net.HttpWebRequest;
using System.Collections;
using System.Threading.Tasks;
using System.IO;
using Sandwich.Services.Parser;

namespace Sandwich.Services.DataProvider
{
    public class DataProvider
    {
      

        public System.Net.HttpWebRequest Request {get; set;}

        public Parse Parser{get;set;}

        public DataProvider()
        {
            Parser = new Parse();
        }


        public async Task<IList<Drinks>> getlstSandwichAsync()
        {

            // Next set up our request URL, headers Content Type.
            System.Net.HttpWebRequest Request = System.Net.HttpWebRequest.CreateHttp(new Uri("https://api.parse.com/1/Drinks"));
            Request.Headers["X-Parse-Application-Id"] = "EBJy7sR5IbWEYU3aLndx2ps10LL8ycT4RuGx87XK";
            Request.Headers["X-Parse-Windows-Key"] = "gPe29yqyMN5pFbi5vK2HgGhyRBIA0VbYuI4dShCC";
            Request.Method = "GET";
            Request.ContentType = "application/json";

            // Fetch a response from the server. This will give us back error codes or a successful code
            var response = await Request.GetResponseAsync();
            string resultJson = string.Empty;

            // Convert Read the Json response in to a string
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                resultJson = streamReader.ReadToEnd();
            }


            return Parser.ParseDrink(resultJson);
      
            
        }




    }
}
