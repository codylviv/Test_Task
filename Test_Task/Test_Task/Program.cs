using Algorithm;
using OOP;
using System;
using System.Collections.Generic;

namespace Test_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("TASK 1\n");
            RailFenceCipher railFenceCipher = new RailFenceCipher();
            Console.WriteLine(railFenceCipher.EncryptRail("WEAREDISCOVEREDFLEEATONCE", 3));
            Console.WriteLine(railFenceCipher.DecryptRail("WECRLTEERDSOEEFEAOCAIVDEN", 3) + "\n");
                                    
            //Task 2
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("TASK 2\n");
            var sideSquare = 1.1234D;
            var radiusCircle = 0.1234D;
            var baseTriangle = 5D;
            var heightTriangle = 2D;
            var shapes = new List<Shape> { new Square(sideSquare), new Circle(radiusCircle), new Triangle(baseTriangle, heightTriangle) };
            shapes.Sort();

            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType() + " = " + item.GetArea());
            }
        }
    }
}
