using System;

namespace OOP
{
    public class Person
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        // A state of an object is the property that are being altered;

        public int CalcuteAge()
        {
            var actualDate = DateTime.Now;
            var age = actualDate.Year - Birthday.Year;

            if (actualDate < Birthday.AddYears(age)) age--;

            return age;
        }

        //The behavior that a class has are the methods. Methods are capable of
        //changing the state of a property or processing/manipulating information in the class.
    }
}
