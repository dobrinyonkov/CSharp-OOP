using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private string name;
        private ICollection<IProduct> cosmetics;

        public Category(string name)
        {
            Validator.ValidateIntRange(name.Length, 2, 15, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));
            this.name = name;
            this.cosmetics = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Add(cosmetics);
        }

        public string Print()
        {
            var str = new StringBuilder();
            if (this.cosmetics.Count == 1)
            {
                str.AppendLine(string.Format("{0} category – {1} product in total",this.name, this.cosmetics.Count));
            }
            else
            {
                str.AppendLine(string.Format("{0} category – {1} products in total", this.name, this.cosmetics.Count));
            }

            return str.ToString().Trim();

        }



        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Remove(cosmetics);
        }
    }
}
