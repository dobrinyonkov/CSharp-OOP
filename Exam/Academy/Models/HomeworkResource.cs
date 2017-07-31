using Academy.Commons;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class HomeworkResource : Resource, ILectureResouce
    {
        private DateTime date;

        public HomeworkResource(string type, string name, string url, DateTime date)
            : base(type, name, url)
        {
            this.date = date;
        }

       
        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("    * Resource:");
            str.AppendLine(string.Format("     - Name: {0}", this.Name));
            str.AppendLine(string.Format("     - Url: {0}", this.Url));
            str.AppendLine("     - Type: Homework");
            str.AppendLine(string.Format("     - Due date: {0}", this.date));

            return str.ToString().Trim();
        }
    }
}
