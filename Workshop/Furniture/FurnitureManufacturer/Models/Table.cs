using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }
    }
}
