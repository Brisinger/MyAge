using System;
using MyAge.Interfaces;

namespace MyAge
{
    public abstract class Person : IPerson
    {
        /// <summary>
        /// Abstract instance of the person.
        /// </summary>
        /// <param name="name">Name of the person.</param>
        /// <param name="birthdate">Birth date of the person.</param>
        public Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; }

        public DateTime Birthdate
        {
            get;
        }

        public abstract int Age { get; }
    }
}
