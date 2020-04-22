using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    abstract class Employee
    {
        // Creates integer variable called "employeeCount" and assigns value to 1
        private static int employeeCount = 1;

        // 3 private member variables: employeeName, employeeBaseSalary, and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeID;

        // Public properties
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

       

        // Constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }
        // This method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        // This method returns the employee's name
        public string getName()
        {
            return this.Name;
        }
        // This method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        public String toString()
        {
            return this.ID + " " + this.Name;
        }
        // This method returns the employee's ID and Name and confirms that the employee is in the system

        //Abstarct method
        public abstract String employeeStatus();
      
    }
}
