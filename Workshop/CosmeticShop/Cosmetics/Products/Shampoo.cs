using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, gender, price)
        {
            this.milliliters = milliliters;
            this.usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
        }

        public UsageType Usage
        {
            get
            {
                return this.usage;
            }
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
