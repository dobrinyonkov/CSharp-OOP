namespace WarMachines.Machines
{
    using Common;
    using System;
    using System.Collections.Generic;

    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public double HealthPoints { get; set; }
          

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Name cannot be null");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                Validator.CheckIfObjIsNull(value, "Pilot canot be null");
                this.pilot = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            Validator.CheckIfStringIsNullOrEmpty(target);
            this.targets.Add(target);
        }
    }
}
