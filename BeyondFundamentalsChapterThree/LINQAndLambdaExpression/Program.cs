using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using LINQ;

namespace LINQAndLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var workers = new List<Worker>() {
                new Worker() { Id = 1, FirstName = "John",LastName = "Ivanov", Age = 18 } ,
                new Worker() { Id= 2, FirstName = "Pesho",LastName = "Iliev", Age = 15 } ,
                new Worker() { Id= 3, FirstName = "George",LastName = "Georgiev", Age = 25 } ,
                new Worker() { Id= 5, FirstName = "Ivan" ,LastName ="Asenev", Age = 19 }
            };
            var filteredResult = from worker in workers
                                 where worker.Age >= 18 && worker.Age <= 24
                                 select worker;
            foreach (var worker in filteredResult)
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName}");
            }

            var workersDesc = workers
          .OrderBy(w => w.FirstName)
          .ThenBy(w => w.LastName);
            foreach (var w in workersDesc)
            {
                Console.WriteLine($"{w.FirstName} {w.LastName}");
            }
            var workerLinq = from worker in workers
                             orderby worker.FirstName, worker.LastName descending
                             select worker;

            foreach (var item in workerLinq)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            int[] numbers = { 3, 7, 9, 21, 10, 55, 100 };
            var resultLambda = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            foreach (var item in resultLambda)
            {
                Console.WriteLine(item);
            }
            var resultLinq = from number in numbers
                             where number % 3 == 0 && number % 7 == 0
                             select number;
            foreach (var item in resultLinq)
            {
                Console.WriteLine(item);
            }



        }
    }
}