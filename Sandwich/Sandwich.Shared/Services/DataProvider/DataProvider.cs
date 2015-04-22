using System;
using System.Collections.Generic;
using System.Text;
using System.Net.HttpWebRequest;

namespace Sandwich.Services.DataProvider
{
    class DataProvider
    {

        public ICollection<Sandwich> getlstSandwich()
        {



            
            curl -X GET \
            -H "X-Parse-Application-Id: EBJy7sR5IbWEYU3aLndx2ps10LL8ycT4RuGx87XK" \
            -H "X-Parse-REST-API-Key: hQtoDMxepJJmQ12RvQ84e4N2agQNbyPTetyj1afW" \
             https://api.parse.com/1/classes/GameScore/Ed1nuqPvcm
        }




    }
}
