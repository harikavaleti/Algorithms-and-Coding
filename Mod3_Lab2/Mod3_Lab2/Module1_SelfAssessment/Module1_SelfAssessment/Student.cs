using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_SelfAssessment
{

     class Student : Person
    {
        public int a { get; set; }
        public int b { get; set; }
        public int ID { get; set; }

        public Student(string name) : base(name,20,"female")
        {
           
        }

        public Student(string name, int id) : base(name, 18, "Male")
        {

        }
          public int GetSum(int a, int  b)
        {
            //Console.WriteLine("Iam ready to take test");
            return a + b;
        }

      
    }
}
