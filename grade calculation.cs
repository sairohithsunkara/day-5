using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public String name;
        public int rollNo, marks;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] sa = new Student[2];
            for (int i = 0; i < sa.Length; i++)
            {
                sa[i] = new Student();
                Console.WriteLine("Enter student name: ");
                sa[i].name = Console.ReadLine();
                Console.WriteLine("Enter student roll no: ");
                sa[i].rollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student marks: ");
                sa[i].marks = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("S.No\t Roll_NO \t Student Name\t\t Percentage\t\tGrades");
            Console.WriteLine();
            char grade;
            for (int i = 0; i < 2; i++)
            {
                int totam = (sa[i].marks * 100) / 500;
                if (totam >= 90 && totam <= 100)
                {
                    grade = 'A';
                }
                else if (totam >= 80 && totam <= 89)
                    grade = 'B';
                else if (totam >= 65 && totam <= 79)
                    grade = 'C';
                else if (totam >= 55 && totam <= 64)
                    grade = 'D';
                else if (totam >= 33 && totam <= 54)
                    grade = 'E';
                else
                    grade = 'F';
                Console.WriteLine((i + 1) + "\t\t" + sa[i].rollNo + "\t\t" + sa[i].name + "\t\t" + totam + "\t\t" + grade);
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}
