using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_SelfAssessment
{
    abstract class Person
    {
        private string personName;
        private int personAge;
        private string personGender;

        public string name
        {
            get
            {
                return personName;
            }
            set
            {
                personName = value;
            }
        }     
        public int age
        {

            get
            {
                return personAge;
            }
            set
            {
                personAge = value;
            }
        }
        public string gender
        {
            get
            {
                return personGender;
            }
            set
            {
                personGender = value;
            }
        }
        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string getname()
        {
            return name;
        }
        public int getage()
        {
            return age;
        }
        public string getgender()
        {
            return gender;
        }

    }
}
