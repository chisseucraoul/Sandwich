using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwich
{
    public class Sandwich : Foods
    {
        private bool crudite;

        public bool Crudite
        {
            get { return crudite; }
            set { crudite = value; }
        }

        private string bread;

        public string Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        public override string ToString()
        {
            return base.NameFood + "; Crudité : " + Crudite + "Type de pain : " + Bread;
        }
    }
}
