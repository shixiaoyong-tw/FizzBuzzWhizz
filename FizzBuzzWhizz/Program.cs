using System;

namespace FizzBuzzWhizz
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentGenerator.Generate(120);

            for (int i = 0; i < students.Length; i++)
            {
                students[i].SayNumber();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
