using Academy.Commons;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public abstract class Resource : ILectureResouce
    {
        private string name;
        private string type;
        private string url;

        public Resource(string type, string name, string url)
        {
            this.type = type;
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.ValidateIntRange(value.Length, 3, 15, "Resource name should be between 3 and 15 symbols long!");
                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.ValidateIntRange(value.Length, 5, 150, "Resource url should be between 5 and 150 symbols long!");
                this.url = value;
            }
        }
    }
}
