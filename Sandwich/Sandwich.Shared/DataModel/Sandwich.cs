using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwich.DataModel
{
    public class Sandwich : Foods
    {
        public bool Crudite { get; set; }

        public string Bread { get; set; }
       

        public override string ToString()
        {
            return base.FrenchName + "; Crudité : " + Crudite + "Type de pain : " + Bread;
        }
    }
}
