using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    class Toothpaste : Product, IToothpaste
    {
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, gender, price)
        {
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get
            {
                return string.Format(string.Join(", ", this.ingredients));
            }
        }
    }
}
