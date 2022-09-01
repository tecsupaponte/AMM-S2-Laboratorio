using System;

namespace Laboratorio_2
{
    public class Rectangle
    {
        private Vertice vertice1 { get; set; }
        private Vertice vertice2 { get; set; }
        private Vertice vertice3 { get; set; }

        public Rectangle(Vertice vertice1, Vertice vertice2, Vertice vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;
        }   

        private double getWidth()
        {
            return Math.Sqrt(Math.Pow(vertice1.x - vertice2.x, 2) + Math.Pow(vertice1.y - vertice2.y, 2));
        }

        private double getHeight()
        {
            return Math.Sqrt(Math.Pow(vertice2.x - vertice3.x, 2) + Math.Pow(vertice2.y - vertice3.y, 2));
        }
        public double getArea()
        {
            return getWidth() * getHeight();
        }

        public double getPerimeter()
        {
            return 2* (getWidth() + getHeight());
        }
    }
}
