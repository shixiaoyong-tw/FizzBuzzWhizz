using System;
using System.Collections.Generic;

namespace FizzBuzzWhizz
{
    /// <summary>
    /// declare student class
    /// </summary>
    public class Student
    {
        public int Number { get; set; }

        private readonly List<Func<Student, (bool, Action)>> MultipleFuncs =
            new List<Func<Student, (bool, Action)>>
            {
                NumberChecker.IsMultipleForThree,
                NumberChecker.IsMultipleForFive,
                NumberChecker.IsMultipleForSeven
            };

        private readonly List<Func<Student, (bool, Action)>> ContainFuncs =
            new List<Func<Student, (bool, Action)>>
            {
                NumberChecker.IsContainThree,
                NumberChecker.IsContainFive,
                NumberChecker.IsContainSeven
            };

        /// <summary>
        /// declare say Fizz method
        /// </summary>
        public void SayFizz()
        {
            Console.Write("Fizz");
        }

        /// <summary>
        /// declare say Buzz method
        /// </summary>
        public void SayBuzz()
        {
            Console.Write("Buzz");
        }

        /// <summary>
        /// declare say Whizz method
        /// </summary>
        public void SayWhizz()
        {
            Console.Write("Whizz");
        }

        /// <summary>
        /// declare say real number method
        /// </summary>
        private void SayRealNumber()
        {
            Console.Write(Number);
        }

        public void SayNumber()
        {
            var multipleFuncsOfTrue = MultipleFuncs.FindAll(x => x.Invoke(this).Item1);
            var containFuncsOfTrue = ContainFuncs.FindAll(x => x.Invoke(this).Item1);

            // judge whether multiple
            if (multipleFuncsOfTrue.Count > 0)
            {
                multipleFuncsOfTrue.ForEach(func =>
                {
                    func.Invoke(this).Item2.Invoke();
                });
            }
            else if (containFuncsOfTrue.Count > 0) // judge whether contain 3、5、7
            {
                containFuncsOfTrue.ForEach(func =>
                {
                    func.Invoke(this).Item2.Invoke();
                });
            }
            else
            {
                SayRealNumber();
            }
        }
    }
}
