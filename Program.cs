using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courseCodes = new List<string>();
            int maxCourses = 6;

            for (int i = 0; i < maxCourses; i++)
            {
                Console.Write($"Enter course code {i + 1} (5 characters): ");
                string courseCode = Console.ReadLine();

                if (courseCode.Length != 5)
                {
                    Console.WriteLine("Error: Course code must be exactly 5 characters long.");
                    i--;
                    continue;
                }
                if (courseCodes.Contains(courseCode))
                {
                    Console.WriteLine("Error: Duplicate course code. Please enter a unique code.");
                    i--;
                    continue;
                }
                courseCodes.Add(courseCode);
                Console.WriteLine($"Course code '{courseCode}' registered successfully.");
            }
            Console.WriteLine("\nRegistered Course Codes:");
            foreach (var code in courseCodes)
            {
                Console.WriteLine(code);
            }
        }
    }
}
              