using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            Validator.ValidateIntRange(content.Length, Constants.MinCommentLength, Constants.MaxCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
            this.content = content;
        }

        public string Author { get; set; }

        public string Content
        {
            get
            {
                return this.content;
            }
        }
    }
}
