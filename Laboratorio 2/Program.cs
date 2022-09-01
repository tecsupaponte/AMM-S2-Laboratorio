using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertice vertice1 = new Vertice();
            Vertice vertice2 = new Vertice();
            Vertice vertice3 = new Vertice();

            Console.WriteLine("Ingresar las coordenas del rectangulo:");

            Console.Write("x1: ");
            vertice1.x = int.Parse((Console.ReadLine()));
            Console.Write("y1: ");
            vertice1.y = int.Parse((Console.ReadLine()));
            Console.Write("x2: ");
            vertice2.x = int.Parse((Console.ReadLine()));
            Console.Write("y2: ");
            vertice2.y = int.Parse((Console.ReadLine()));
            Console.Write("x3: ");
            vertice3.x = int.Parse((Console.ReadLine()));
            Console.Write("y3: ");
            vertice3.y = int.Parse((Console.ReadLine()));

            double area = new Rectangle(vertice1, vertice2, vertice3).getArea();
            double perimeter = new Rectangle(vertice1, vertice2, vertice3).getPerimeter();

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimetro: " + perimeter);

        }
    }
}
