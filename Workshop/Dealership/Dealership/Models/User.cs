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
    class User : IUser
    {
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private string username;
        private ICollection<IVehicle> vehicles;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            Validator.ValidateIntRange(username.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
            Validator.ValidateSymbols(username, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "Username"));
            this.username = username;
            Validator.ValidateIntRange(firstName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "First Name", Constants.MinNameLength, Constants.MaxNameLength));
            this.firstName = firstName;
            Validator.ValidateIntRange(lastName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Last Name", Constants.MinNameLength, Constants.MaxNameLength));
            this.lastName = lastName;
            Validator.ValidateIntRange(password.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
            this.password = password;
            this.role = (Role)Enum.Parse(typeof(Role), role);

            this.vehicles = new List<IVehicle>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Role Role
        {
            get
            {
                return this.role;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                return new List<IVehicle>(vehicles);
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            
            if (this.Role == Role.Normal && this.vehicles.Count >= 5)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, 5));
            }
            else
            {
                this.vehicles.Add(vehicle);
            }
            if (this.Role == Role.VIP)
            {
                this.vehicles.Add(vehicle);
            }
        }

        public string PrintVehicles()
        {
            var str = new StringBuilder();
            str.AppendLine(string.Format("--USER {0}--", this.Username));
            foreach (var v in this.Vehicles)
            {
                str.AppendLine(string.Format("{0}:", v.Type));
                str.AppendLine(string.Format("Make: {0}", v.Make));
                str.AppendLine(string.Format("Model: {0}", v.Model));
                str.AppendLine(string.Format("Wheels: {0}", v.Wheels));
                str.AppendLine(string.Format("Model: {0}", v.Model));
            }
            return str.ToString();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
        }

        public override string ToString()
        {
            return string.Format(Constants.UserToString, this.Username, this.FirstName, this.LastName);
        }
    }
}

