using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LabEncapsulation
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person()
        {
        }

        public Person(string first, string last, int age)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = age;
            
        }
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public int Age { get { return this.age; }}
        
       
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
