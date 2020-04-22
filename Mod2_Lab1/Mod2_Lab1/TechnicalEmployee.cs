using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // TechnicalEmployee Class inheriting from Employee Class
    class TechnicalEmployee : Employee
    {

        // Creates integer variable called "successfulCheckIns" and assigns value to 5
        public int successfulCheckIns = 5; 

        // Calls upon base-class (Employee Class) constructor from within derived class (TechnicalEmployee Class)
        // Sets baseSalary to 75000 for all TechnicalEmployee objects
        public TechnicalEmployee(String name) : base(name, 75000)
        {

        }

        // This method returns the toString() method - which is the employee's ID number and name - and prints the number of successful check ins the employee has had 
        public override String employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
        
    }
}
