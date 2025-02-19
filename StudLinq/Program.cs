using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudLinqRequests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Students> students = new List<Students>();
            List<string> names = new List<string>() { "Тельман", "Барковский", "Усов", "Эрик", "Арбуз", "Иван" };
            List<string> faculteti = new List<string>() { "Пивоварение", "IT", "Менеджмент", "Армия", "Там-Сям туда сюда" };
            List<int> numbers = new List<int>();

            int quantityOfStudents = random.Next(10, 100);
            int quantityOfNumbers = random.Next(20, 100);
            int randomNumber = random.Next(0, 100);

            for (int i = 0; i < quantityOfNumbers; i++)
            {
                numbers.Add(random.Next(-50, 100));
            }

            for (int i = 0; i < quantityOfStudents; i++)
            {
                students.Add(
                    new Students()
                    {
                        Id = i + 1,
                        Cours = random.Next(1, 5),
                        Age = random.Next(16, 23),
                        Name = names[random.Next(0, names.Count)],
                        Facultet = faculteti[random.Next(0, faculteti.Count)],
                    }
                );
            }



            //List<Students> filteredstudents = students.Where(student => student.Age >= 20).ToList();

            //List<int> lineLenght = students.Select(x => x.Name.Length).ToList();

            //var filteredstudents1 = students.OrderBy(student => student.Id);

            //foreach (var item in filteredstudents1)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Students> filteredstudents = students.Where(student => student.Id == 3).ToList();

            //var filteredstudents = students.Count(student => student.Id == student.Id);
            //Console.WriteLine(filteredstudents);

            //List<Students> filteredstudents = students.Where(student => student.Name.StartsWith("А")).ToList();

            //List<Students> filteredstudents = students.Where(student => student.Name.Contains("Иван")).ToList();

            //List<Students> filteredstudents = students.Where(student => student.Cours == 1).ToList();

            //int maxAge = students.Max(s => s.Age);

            //List<int> filteredNumbers = numbers.Where(x => x % 2 == 0).ToList();

            //int maxNumber = numbers.Max(x => x);

            //List<int> filteredNumbers = numbers.Where(x => x >= 0).ToList();

            //var filteredstudents = students.Where(x => x.Age > 10).ToList();

            //double avgAge = Math.Round(students.Average(x => x.Age), 1);

            //int minAge = students.Min(x => x.Age);

            //var response = from s in students
            //               where s.Id == 2
            //               select s;



            for (int i = 0; i < quantityOfStudents; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < quantityOfNumbers; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Результат выборки:");

            //Console.WriteLine(response);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(Math.Pow(numbers[i], 2));
            //}

            //for (int i = 0; i < lineLenght.Count; i++)
            //{
            //    Console.WriteLine(lineLenght[i]);
            //}



            Console.ReadKey();
        }
    }
}
