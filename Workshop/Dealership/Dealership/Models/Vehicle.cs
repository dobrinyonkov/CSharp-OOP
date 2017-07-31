using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected ICollection<IComment> comments;
        private string make;
        private string model;
        private decimal price;
        protected int wheels;

        public Vehicle(string make, string model, decimal price)
        {
            Validator.ValidateIntRange(make.Length, Constants.MinMakeLength, Constants.MaxMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
            this.make = make;
            Validator.ValidateIntRange(model.Length, Constants.MinModelLength, Constants.MaxModelLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));
            this.model = model;
            Validator.ValidateDecimalRange(price, Constants.MinPrice, Constants.MaxPrice, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
            this.price = price;
            this.comments = new List<IComment>();
            this.wheels = (int)this.Type;
        }

        public IList<IComment> Comments
        {
            get
            {
                return new List<IComment>(comments);
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public VehicleType Type { get; }

        public int Wheels
        {
            get
            {
                return this.wheels;
            }
        }
    }
}
