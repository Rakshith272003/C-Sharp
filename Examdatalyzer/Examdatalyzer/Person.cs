using System;
namespace EmployeeApp
{

    abstract class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public abstract void DisplayDetails();
    }
}