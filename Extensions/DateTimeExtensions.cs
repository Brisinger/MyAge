using System;

namespace MyAge.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            if (birthdate.DayOfYear > DateTime.Now.DayOfYear)
                age--;
            return age;
        }
    }
}

/*commit from local 
