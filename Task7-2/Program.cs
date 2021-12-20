using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int edgeLength = Convert.ToInt32(Console.ReadLine());            
            double squareCube, volumeCube;
            CalculateSquareVolume(edgeLength, out squareCube, out volumeCube);
            Console.WriteLine("Площадь поверхности куба равна {0}", squareCube);
            Console.WriteLine("Объем куба равен {0}", volumeCube);
            Console.ReadKey();
        }
        static void CalculateSquareVolume(int edgeLength, out double squareCube, out double volumeCube)
        {
            squareCube = 6 * (Math.Pow(edgeLength, 2));
            volumeCube = Math.Pow(edgeLength, 3);
        }
    }
}
