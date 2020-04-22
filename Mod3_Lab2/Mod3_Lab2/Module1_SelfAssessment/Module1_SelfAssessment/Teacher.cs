using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_SelfAssessment
{
    class Teacher : Person
    { 
        public String Department { get; set; }
        
        public Teacher(string name) : base(name,20,"Female")
        {
           
        }
        public Teacher(string name, string Department) : base(name, 19, "Male")
        {
            Department = this.Department;
        }
       public string GradeTest()
        {
            //Console.WriteLine("Test");
            return "Take sum test";
        }
   
    }
}
