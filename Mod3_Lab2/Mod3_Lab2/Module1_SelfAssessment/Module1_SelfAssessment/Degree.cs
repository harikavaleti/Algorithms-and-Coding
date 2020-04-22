using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_SelfAssessment
{
     
    class Degree
    {
        public Course course { get; set; }
        public string Name { get; set; }
        
        public int Duration { get; set; }

        public string getcName()
        {
            return course.CourseName;
        }
        public Degree(String name, int duration)
        {
            Name = name;
            Duration = duration;
        }
    }
}
