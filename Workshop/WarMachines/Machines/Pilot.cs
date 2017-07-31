namespace WarMachines.Machines   
{
    using Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Name cannot be null");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfObjIsNull(machine, "Null machine cannot be added to pilot");
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines =
                 this.machines
                 .OrderBy(m => m.HealthPoints)
                 .ThenBy(m => m.Name);

            var result = new StringBuilder();

            var noMachinesMaybe = this.machines.Count > 0
                ? this.machines.Count.ToString()
                : "no";

            var plurarMachinesMaybe = this.machines.Count == 1
                ? "machine"
                : "machines";

            result.AppendLine(string.Format("{0} - {1} {2}", this.name, noMachinesMaybe, plurarMachinesMaybe));

            foreach (var item in sortedMachines)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString();
        }
    }
}
