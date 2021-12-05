using System;


namespace MyAge.Interfaces
{
    public interface IPerson
    {
        /// <summary>
		/// Age of the person.
		/// </summary>
        int Age
        {
            get;
        }

        /// <summary>
		/// Birthdate of the person.
		/// </summary>
        DateTime Birthdate { get; }

        /// <summary>
		/// Name of the person.
		/// </summary>
        string Name { get; }

    }
}
