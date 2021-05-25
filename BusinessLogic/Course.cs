using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        const string DefaultInstructor = "STAFF";
        private byte numberOfCredits;
        private string courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = DefaultInstructor;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName 
        { 
            get => courseName;

            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }
                courseName = value;
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numberOfCredits;

            set
            {
                if (value <= 0 || value >= 30)
                {
                    throw new ArgumentException();
                }
                numberOfCredits = value;
            }
        }

    }
}
