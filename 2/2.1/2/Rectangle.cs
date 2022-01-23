using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : Square
    {
        public int SecondSide { get; set; }
        public Rectangle(int x, int y, int side, int secondSide) : base(x,y,side)
        {
                SecondSide = secondSide;
        }
        public Rectangle():base()
        {
            Console.WriteLine("Введите вторую строну: ");
            SecondSide = int.Parse(Console.ReadLine());
        }

        override public int Perimetr { get => (FirstSide + SecondSide)*2; }
        override public int Area { get => FirstSide * SecondSide; }
        public override void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : прямоугольник");
            Console.WriteLine("Коодринаты: X = {0}, Y = {1}", X, Y);
            Console.WriteLine("Периметр = {0}", Perimetr);
            Console.WriteLine("Площадь = {0}", Area);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
