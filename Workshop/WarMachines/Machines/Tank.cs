namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    class Tank : Machine, ITank, IMachine
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointChange = 40;
        private const int DefensePointChange = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            :base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !DefenseMode;
            if (DefenseMode)
            {
                this.AttackPoints -= AttackPointChange;
                this.DefensePoints += DefensePointChange;
            }
            else
            {
                this.AttackPoints += AttackPointChange;
                this.DefensePoints -= DefensePointChange;
            }
        }
    }
}
