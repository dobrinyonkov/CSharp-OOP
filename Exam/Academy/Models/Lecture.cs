using Academy.Commons;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private string name;
        private ICollection<ILectureResouce> resouces;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = Convert.ToDateTime(date);
            this.Trainer = trainer;
            this.resouces = new List<ILectureResouce>();
        }

        public DateTime Date { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateIntRange(value.Length, 5, 30, "Lecture's name should be between 5 and 30 symbols long!");
                this.name = value;
            }
        }

        public IList<ILectureResouce> Resouces { get; set; }

        public ITrainer Trainer { get; set; }

        public override string ToString()
        {
            var str = new StringBuilder();

            str.AppendLine("  * Lecture:");
            str.AppendLine(string.Format("   - Name: {0}", this.Name));
            str.AppendLine(string.Format("   - Name: {0}", this.Name));
            str.AppendLine(string.Format("   - Date: {0}", this.Date));
            str.AppendLine(string.Format("   - Trainer username: {0}", this.Trainer.Username));
            str.AppendLine("   - Resources:");
            if (this.Resouces.Count == 0)
            {
                str.AppendLine("    * There are no resources in this lecture.");
            }
            else
            {
                foreach (var res in Resouces)
                {
                    str.AppendLine(res.ToString());
                }  
            }

            return str.ToString().Trim();
        }
    }
}
