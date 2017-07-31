using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Commons;

namespace Academy.Models
{
    class CourseResult : ICourseResult
    {
        private ICourse course;
        private float coursePoints;
        private float examPoints;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);
        }

        public ICourse Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                Validator.CheckIfNull(value);
                this.course = value;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.examPoints;
            }
            private set
            {
                Validator.ValidateFloatInRange(value, 0, 125, "Course result's course points should be between 0 and 125!");
                this.coursePoints = value;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
            private set
            {
                Validator.ValidateFloatInRange(value, 0, 1000, "Course result's exam points should be between 0 and 1000!");
                this.examPoints = value;
            }
        }

        public Grade Grade
        {
            get
            {
                if (this.examPoints >= 65 || this.coursePoints >= 75)
                {
                    return Grade.Excellent;
                }
                if ((this.examPoints < 60 || this.examPoints >= 30) || (this.coursePoints < 75 || this.coursePoints >= 45))
                {
                    return Grade.Passed;
                }
                return Grade.Failed;
            }
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine(string.Format(" * {0}: Points - {1}, Grade - {2}", this.course.Name, this.CoursePoints, this.Grade));
            return str.ToString().Trim();
        }
    }
}
