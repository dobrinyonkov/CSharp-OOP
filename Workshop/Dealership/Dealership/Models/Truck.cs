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
    class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            Validator.ValidateIntRange(weightCapacity, Constants.MinCapacity, Constants.MaxCapacity, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));
            this.weightCapacity = weightCapacity;
            this.wheels = (int)VehicleType.Truck;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
        }
    }
}
