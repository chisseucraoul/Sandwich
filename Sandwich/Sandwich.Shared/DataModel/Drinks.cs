using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwich.DataModel
{
    public class Drinks : Foods
    {
        public override string ToString()
        {
            return base.FrenchName;
        }
    }
}
