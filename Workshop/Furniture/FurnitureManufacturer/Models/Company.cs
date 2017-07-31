using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            protected set
            {
                if (value == null || value.Length < 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbol");
                }
                if (this.ContainsOnlyDigits(value))
                {
                    throw new ArgumentException("Registration number must contain only digit");
                }
                this.registrationNumber = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            throw new NotImplementedException();
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public bool ContainsOnlyDigits(string str)
        {
            foreach (var ch in str)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
