﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    enum ShapeType
    {
        Circle,
        Disc,
        Ring,
        Square,
        Rectangle,
    }
    internal class Program
    {
        public static void SetUsername(string name)
        {
            Console.WriteLine("Здравствуйте, введите ваше новое имя: ");
            name = Console.ReadLine();
        }
        public static void CreateShape(ShapeType shape, List<Shape> list)
        {
            int x = 0, y = 0, rad = 0;
            switch (shape)
            {
                case ShapeType.Circle:
                    list.Add(new Circle());
                    break;

                case ShapeType.Disc:
                    list.Add(new Disc());
                    break;

                case ShapeType.Ring:
                    list.Add(new Ring());
                    break;

                case ShapeType.Square:
                    list.Add(new Square());
                    break;
                case ShapeType.Rectangle:
                    list.Add(new Rectangle());
                    break;
            }
        }
        public static void PrintShapes(List<Shape> list)
        {
            foreach (var shape in list)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                shape.Print();
            }
        }
        static void Main(string[] args)
        {
            string userName = null;
            var canvas = new List<Shape>();
            bool exit = false;

            Console.WriteLine("Здравствуйте, введите ваше имя: ");
            userName = Console.ReadLine();
            while (!exit)
            {
                Console.WriteLine("Hello, {0}, make a choose", userName);
                Console.WriteLine("1. добавить фигуру\n2. вывести фигуры\n3. очистить холст\n 4. сменить пользователя");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nВведите тип фигуры: ");
                        Console.WriteLine("0 - окружность, 1 - диск, 2 - кольцо, 3 - квадрат, 4 - треугольник");
                        ShapeType key = (ShapeType)int.Parse(Console.ReadLine());
                        CreateShape(key, canvas);
                        break;
                    case ConsoleKey.D2:
                        PrintShapes(canvas);
                        break;
                    case ConsoleKey.D3:
                        canvas.Clear();
                        Console.WriteLine("Холст очищен!");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("Здравствуйте, введите ваше новое имя: ");
                        userName = Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
