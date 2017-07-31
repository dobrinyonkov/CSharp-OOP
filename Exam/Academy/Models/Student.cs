using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;

namespace Academy.Models
{
    public class Student : User, IStudent
    {
        private Track track;

        public Student(string username, string track)
            :base(username)
        {
            this.Track = (Track)Enum.Parse(typeof(Track), track);
            this.CourseResults = new List<ICourseResult>();
        }

        public IList<ICourseResult> CourseResults { get; set; }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                if (!Enum.IsDefined(typeof(Track), value))
                {
                    throw new ArgumentException("The provided track is not valid!");
                }
                this.track = value;
            }
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("* Student:");
            str.AppendLine(string.Format(" - Username: {0}", this.username));
            str.AppendLine(string.Format(" - Track: {0}", this.track.ToString()));
            str.AppendLine(" - Course results:");
            if (this.CourseResults.Count == 0)
            {
                str.AppendLine("  * User has no course results!");
            }
            else
            {
                foreach (var cr in CourseResults)
                {
                    str.AppendLine(CourseResults.ToString());
                }
            }
            return str.ToString().Trim();
        }
    }
}
