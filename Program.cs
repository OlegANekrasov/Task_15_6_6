using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_15_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            
            var allStudents = GetAllStudents(classes);
            if (allStudents != null)
            {
                Console.WriteLine(string.Join(" ", allStudents));
            }

            Console.ReadLine();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            string[] result = null;
            foreach(var cr in classes)
            {
                if(result == null)
                {
                    result = cr.Students.ToArray();
                }
                else
                {
                    result = cr.Students.Concat(result).ToArray();
                }
            }

            return result;
        }
    }
}
