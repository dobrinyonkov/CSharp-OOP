using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Fighter : Machine, IFighter, IMachine
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            :base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.StealthMode = stealthMode;
        }
        
        public bool StealthMode { get; set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
    }
}
