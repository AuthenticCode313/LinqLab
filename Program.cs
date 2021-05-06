using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            MinNum(nums);
            MaxNum(nums);
            EvenNumbers(nums);
            Over21(students);
            Youngest(students);
            Oldest(students);
            Between13And19(students);
            Max1000(nums);
            Between(nums);
            BetweenAndInclusive(nums);
            Over21AndEven(students);
            OldestUnder25(students);
        }

        static void Youngest(List<Student> students)
        {
            int minAge = students.Min(student => student.Age);
            Console.WriteLine($"The youngest age is {minAge}");
        }
        static void Oldest(List<Student> students)
        {

            int maxAge = students.Max(s => s.Age);
            Console.WriteLine($"The oldest age is {maxAge}");
        }
        static void OldestUnder25(List<Student> students)
        {
            int oAge = students.Count(s => s.Age <= 25);
            Console.WriteLine($"The oldest student under the age of 25 is {oAge}");
        }

        static void Over21(List<Student> students)
        {
            List<Student> studentss = students.Where(s => s.Age >= 21).ToList();

            Console.WriteLine($"There are {studentss.Count} that are 21 and over.");
        }

        static void Between13And19(List<Student> students)
        {
            var betweenThem = students.Where(s => s.Age >= 13 && s.Age <= 30).ToList();

            Console.WriteLine($"There are {betweenThem.Count} students between 13 and 19.");
        }
        static void Over21AndEven(List<Student> students)
        {
            //List<Student> studentss = students.Where(s => s.Age >= 21 && s.Age % 2 == 0).ToList();
            //Console.WriteLine($"There are {students.Count} students that are over 21 and even.");
            var over21Even = students.Where(s => s.Age >= 21 && s.Age %2 == 0).ToList();
            Console.WriteLine($"There are {over21Even.Count} students that are over 21 and even.");

         
        }
        static void MinNum(int[] nums)
        {
            int minNum = nums.Min();

            Console.WriteLine($"The minimum value is {minNum}.");
        }

        static void MaxNum(int[] nums)
        {
            int maxNum = nums.Max();
            Console.WriteLine($"The maximun value is {maxNum}.");
        }

        static void Max1000(int[] nums)
        {
            int maxNum = nums.Max();
            int numms = nums.Count(maxNum => maxNum < 10000);
            Console.WriteLine($"The maximum values less than 10000 is {numms}.");

        }

        static void BetweenAndInclusive(int[] nums)
        {
            int inc = nums.Count(n => n >= 100000 && n <= 999999);

            Console.WriteLine(inc);
        }

        static void Between(int[] nums)
        {
            int between = nums.Count(n => n > 10 && n < 100);
           
                Console.WriteLine(between);
            
        }
        static void EvenNumbers(int[] nums)

        {
            int numss = nums.Count(n => n % 2 == 0);
            Console.WriteLine($"There are {numss} even numbers.");

        }
        
    
    }
}
