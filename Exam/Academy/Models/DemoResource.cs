using Academy.Commons;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class DemoResource : Resource, ILectureResouce
    {
        private string name;
        private string type;
        private string url;

        public DemoResource(string type, string name, string url)
            : base(type, name, url)
        {
            
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("    * Resource:");
            str.AppendLine(string.Format("     - Name: {0}", this.Name));
            str.AppendLine(string.Format("     - Url: {0}", this.Url));
            str.AppendLine("     - Type: Demo");

            return str.ToString().Trim();
        }
    }
}
