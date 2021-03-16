using System;

namespace FizzBuzzWhizz
{
    /// <summary>
    /// declare a class for judge number rule
    /// </summary>
    public static class NumberChecker
    {
        /// <summary>
        /// declare a method for judge 3 multiple 
        /// </summary>
        public static (bool, Action) IsMultipleForThree(Student student)
        {
            return (student.Number % 3 == 0, () => student.SayFizz());
        }

        /// <summary>
        /// declare a method for judge 5 multiple
        /// </summary>
        public static (bool, Action) IsMultipleForFive(Student student)
        {
            return (student.Number % 5 == 0, () => student.SayBuzz());
        }

        /// <summary>
        /// declare a method for judge 7 multiple
        /// </summary>
        public static (bool, Action) IsMultipleForSeven(Student student)
        {
            return (student.Number % 7 == 0, () => student.SayWhizz());
        }

        /// <summary>
        /// declare a method for judge contain 3
        /// </summary>
        public static (bool, Action) IsContainThree(Student student)
        {
            return (student.Number.ToString().Contains("3"), () => student.SayFizz());
        }

        /// <summary>
        /// declare a method for judge contain 5
        /// </summary>
        public static (bool, Action) IsContainFive(Student student)
        {
            return (student.Number.ToString().Contains("5"), () => student.SayBuzz());
        }

        /// <summary>
        /// declare a method for judge contain 7
        /// </summary>
        public static (bool, Action) IsContainSeven(Student student)
        {
            return (student.Number.ToString().Contains("7"), () => student.SayWhizz());
        }
    }
}
