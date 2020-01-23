using System;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hailee";
            int grade = 98;
            char letterGrade = 'A';
            double costOfTuition = 15000.00;

            Console.WriteLine($"{firstName} is a student, {grade} is the grade she earned. Which is an {letterGrade} and it costs {costOfTuition} to attend her classes.");
        }
    }
}
