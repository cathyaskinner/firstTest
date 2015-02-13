/* 
 A fleet is a collection of cars. Each car has a make, model,
 * registration and engine size (cc). Implement a car class and override ToString() as usual. 
 * Create a fleet collection in memory and populate with some cars.

Write LINQ queries on the fleet to:
1. List all cars in ascending registration order
2. List the models for all Mazda cars in the fleet
3. List all cars in descending engine size order
4. List just the make and model for cars whose engine size is 1600 cc
5. Count the number of cars whose engine size is 1600 cc or less

 */

using System;
using System.Collections.Generic;
using System.Linq;


namespace CathyLinq
{
    class Program
    {
        static void Main()
        {
            Car c1 = new Car("Ford", "Fiesta", "09-d-29292", 1400);
            Car c2 = new Car("Mazda", "626", "08-ww-232", 1600);
            Car c3 = new Car("Mazda", "323", "03-erd-1412", 1800);
            Car c4 = new Car("Toyota", "Yaris", "00-rd-121", 1600);
            Car c5 = new Car("Skinner", "Special", "15-itt-123", 2000);



            List<Car> cars = new List<Car>();
            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(c4);
            cars.Add(c5);


            //foreach(Car c in cars)
            //{
            //    Console.WriteLine(c);
            //}

            //var regOrder = cars.OrderBy(i => i.Registration);

            //foreach (var v in regOrder)
            //{

            //    Console.WriteLine(v);
            //}

            //var modelList = cars.Where(i => i.Make == "Mazda").Select(i=> i.Model);

            //foreach (var m in modelList)
            //{
            //    Console.WriteLine(m);
            //}

            //var EngSOrder = cars.OrderByDescending(i => i.EngineSize);
            
            //foreach (var es in EngSOrder)
            //{
            //    Console.WriteLine(es);
            //}


            //var Gary = cars.Where(i => i.EngineSize == "1600").Select(i => new { i.Make, i.Model });

            //foreach (var g in Gary)
            //{
            //    Console.WriteLine(g);
            //}


            var Count = cars.Count(i => i.EngineSize <= 1600);

            
                Console.WriteLine(Count);
            

        }
    }
}
