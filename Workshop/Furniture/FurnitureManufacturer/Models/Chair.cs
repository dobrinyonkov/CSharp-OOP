using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Chair : Furniture, IChair
    {
        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; protected set; }
    }
}
