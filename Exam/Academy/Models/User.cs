using Academy.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public abstract class User : IUser
    {
        protected string username;

        protected User(string username)
        {
            this.Username = username;
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.ValidateIntRange(value.Length, 3, 16, "User's username should be between 3 and 16 symbols long!");
                this.username = value;
            }
        }
    }
}
