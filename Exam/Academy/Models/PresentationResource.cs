using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    class PresentationResource : Resource, ILectureResouce
    {
        public PresentationResource(string type, string name, string url) 
            : base(type, name, url)
        {

        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("    * Resource:");
            str.AppendLine(string.Format("     - Name: {0}", this.Name));
            str.AppendLine(string.Format("     - Url: {0}", this.Url));
            str.AppendLine("     - Type: Presentation");

            return str.ToString().Trim();
        }
    }
}
