namespace FizzBuzzWhizz
{
    /// <summary>
    /// delare a student generate class for student
    /// </summary>
    public static class StudentGenerator
    {
        /// <summary>
        /// declare a stuent generate method for student
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Student[] Generate(int studentNumber)
        {
            var students = new Student[studentNumber];

            for (int i = 0; i < studentNumber; i++)
            {
                students[i] = new Student
                {
                    Number = i + 1
                };
            }

            return students;
        }
    }
}
