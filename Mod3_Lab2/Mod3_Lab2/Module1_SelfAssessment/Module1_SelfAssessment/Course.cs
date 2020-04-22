using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_SelfAssessment
{
     class Course
    {  
        public List<Student> studentList { get; set; }
        public List<Teacher> teacherList { get; set; } 
        public string CourseName { get; set; }
        
        public int CourseID { get; set; }
        
        public Course(string name, int id)
        {
          CourseName = name;
          CourseID = id;
        }
        public Course(string name)
        {
            CourseName = name;
        }
          

    }
}
