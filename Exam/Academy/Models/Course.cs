using Academy.Commons;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private string lecturesPerWeek;
        private string startingDate;
        private string name;
        private ICollection<ILecture> lectures;
        private ICollection<IStudent> onlineStudents;
        private ICollection<IStudent> onsiteStudents;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.startingDate = startingDate;
            this.lectures = new List<ILecture>();
            this.onlineStudents = new List<IStudent>();
            this.onsiteStudents = new List<IStudent>();
        }

        public DateTime EndingDate { get; set; }

        public IList<ILecture> Lectures
        {
            get
            {
                return new List<ILecture>(this.lectures);
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return int.Parse(this.lecturesPerWeek);
            }

            set
            {
                Validator.ValidateIntRange(value, 1, 7, "The number of lectures per week must be between 1 and 7!");
                this.lecturesPerWeek = value.ToString();
            }
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
                Validator.ValidateIntRange(value.Length, 3, 45, "The name of the course must be between 3 and 45 symbols!");
                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return new List<IStudent>(this.onlineStudents);
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return new List<IStudent>(this.onsiteStudents);
            }
        }

        public DateTime StartingDate { get; set; }

        public override string ToString()
        {

            var str = new StringBuilder();
            str.AppendLine(string.Format("* Course:"));
            str.AppendLine(string.Format(" - Name: {0}", this.Name));
            str.AppendLine(string.Format(" - Lectures per week: {0}", this.LecturesPerWeek));
            str.AppendLine(string.Format(" - Starting date: {0}", String.Format("{0:M/d/yyyy}", this.StartingDate)));
            str.AppendLine(string.Format(" - Ending date: {0}", String.Format("{0:M/d/yyyy}", this.EndingDate)));
            str.AppendLine(string.Format(" - Lectures:"));
            if (this.lectures.Count > 0)
            {
                str.AppendLine(string.Join(", ", this.lectures));
            }
            else
            {
                str.AppendLine("  * There are no lectures in this course!");
            }
            return str.ToString().Trim();
        }
    }
}
