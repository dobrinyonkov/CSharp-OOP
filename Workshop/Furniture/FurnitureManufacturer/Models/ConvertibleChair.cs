using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;
        private const decimal ConvertedHeight = 0.10m;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs) 
            : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
        }

        public void Convert()
        {
            if (this.isConverted)
            {
                this.isConverted = false;
            }
            else
            {
                this.isConverted = true;
            }
        }
        public override decimal Height
        {
            get
            {
                if (this.isConverted)
                {
                    return ConvertedHeight;
                }
                else
                {
                    return base.Height;
                }
            }
            protected set
            {
                base.Height = value;
            }
        }
    }
}
