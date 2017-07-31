using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Trainer : User, ITrainer
    {
    
        private ICollection<string> technologies;

        public Trainer(string username, string technologies)
            :base(username)
        {
            this.technologies = new List<string>();
            this.technologies.Add(technologies);
        }

        public IList<string> Technologies { get; set; }
        
        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine(string.Format("* Trainer:"));
            str.AppendLine(string.Format(" - Username: {0}", this.Username));
            str.AppendLine(string.Format(" - Technologies: {0}", string.Join("; ", this.Technologies)));

            return str.ToString().Trim();
        }

    }
}
