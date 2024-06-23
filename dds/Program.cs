using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[1];
             for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Person();
                person[i].Id = Convert.ToInt32(Console.ReadLine());
                person[i].Name = Console.ReadLine();
                person[i].Age = Convert.ToInt32(Console.ReadLine());
                person[i].Salary = Convert.ToInt32(Console.ReadLine());
                if (person[i].Salary > 10000000)
                {
                    person[1].Message = "save";
                    Console.WriteLine(person[1].Message);
                }
                else {
                    person[0].Message = "kamtar az 10 mmil";
                    Console.WriteLine(person[0].Message);

                        }
            }
       
        }
    }
}
