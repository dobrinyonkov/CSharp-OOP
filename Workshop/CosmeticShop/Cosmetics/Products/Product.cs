using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private string brand;
        private GenderType gender;
        private string name;
        private decimal price;

        public Product(string name, string brand, GenderType gender, decimal price)
        {
            Validator.CheckIfStringIsNullOrEmpty(brand, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
            Validator.ValidateIntRange(brand.Length, 2, 10, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10));
            this.brand = brand;

            Validator.CheckIfStringIsNullOrEmpty(name, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
            Validator.ValidateIntRange(name.Length, 3, 10, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", 3, 10));
            this.name = name;

            Validator.CheckIfNull(gender, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Gender"));
            this.gender = gender;

            Validator.ValidateIntRange(name.Length, 2, 15, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));
            Validator.CheckIfNull(price, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product price"));
            this.price = price;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public string Print()
        {
            var str = new StringBuilder();
            str.AppendLine(string.Format("- {0} – {1}:", this.brand, this.name));
            str.AppendLine(string.Format("  * Price: ${0}", this.price));
            str.AppendLine(string.Format("  * For gender: {0}", this.gender));

            return str.ToString();
        }
    }
}
