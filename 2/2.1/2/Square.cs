using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Square : Shape
    {
        public int FirstSide { get; set; }
        public Square(int x, int y, int  side) :base(x,y)
        {
            FirstSide = side;
        }
        public Square() : base()
        {
            Console.WriteLine("Задайте сторону : ");
            FirstSide = int.Parse(Console.ReadLine());
        }

        virtual public int Perimetr { get => FirstSide * 4; }
        virtual public int Area { get => FirstSide * FirstSide; }
        public override void Print()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Фигура : квадрат");
            Console.WriteLine("Коодринаты: X = {0}, Y = {1}", X, Y);
            Console.WriteLine("Периметр = {0}", Perimetr);
            Console.WriteLine("Площадь = {0}", Area);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
