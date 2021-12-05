using System;
using MyAge.Extensions;

namespace MyAge
{
    /// <summary>
    /// Class representing Shubhojit.
    /// </summary>
    public class Shubhojit : Person
    {
        /// <summary>
        /// Create an instance of Shubhojit.
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="birthDate">Birthdate.</param>
        public Shubhojit(string name, DateTime birthDate) : base(name, birthDate)
        {
        }

        /// <summary>
        /// Gets the age of Shubhojit.
        /// </summary>
        public override int Age
        {
            get => Birthdate.CalculateAge();
        }
    }
}
