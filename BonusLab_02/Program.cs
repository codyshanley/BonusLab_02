using System;

namespace BonusLab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Age Calculator!");

            Console.Write("Enter birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.Write("Enter birth month: (ie. April = 4)");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.Write("Enter birth day: ");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(birthDate.ToString("yyyyMMdd"));

            int age = (now - dob) / 10000;
            Console.WriteLine("You are " + age + " years old.");

            if ((birthDate.Month == DateTime.Now.Month) && (birthDate.Day == DateTime.Now.Day))
            {
                Console.WriteLine("Happy birthday!");
            }
        }
    }
}
