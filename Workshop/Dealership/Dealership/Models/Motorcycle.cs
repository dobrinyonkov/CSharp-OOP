using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;
      
        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            Validator.ValidateIntRange(category.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
            this.category = category;
            this.wheels = (int)VehicleType.Motorcycle;
        }

        public string Category
        {
            get
            {
                return this.category;
            }
        }
    }
}
