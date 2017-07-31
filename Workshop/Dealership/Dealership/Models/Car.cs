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
    class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            Validator.ValidateIntRange(seats, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));

            this.seats = seats;
            this.wheels = (int)VehicleType.Car;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
        }
    }
}
