using System;
using System.Linq;

namespace PointGraph
{
    /// <summary>
    /// This progream intended to plot dot graphs and save it to png format. 
    /// </summary>
    class Program
    {
        static void Main()
        {
            try
            {
                HelloMenu(); 
                DotPlot dotPlot = new DotPlot(InputX(), InputY()); //Creating an object of Dotpoint class
                Console.Write("Введите название файла: ");
                dotPlot.FileName = Console.ReadLine();
                dotPlot.GetGraph();
                Console.WriteLine("График построен и сохранен");
            }
            catch 
            {
                Console.WriteLine("Ошибка ввода!");
                Console.WriteLine("Попробуйте еще раз");
                Console.ReadKey();
                Console.Clear();
                Main();
                Console.WriteLine();
                
            }
        }
        static void HelloMenu()
        {
            Console.WriteLine("  _____      _       _      _____                 _     \n " +
                              "|  __ |    (_)     | |    / ____|               | |    \n" +
                              " | |__) |__  _ _ ___| |_  | |  __ _ __ __ _ _ __ | |___ \n" +
                              " |  ___/ _ || | '_  | __| | | |_ | '__/ _` | '_ || '_  | \n" +
                              " | |  | (_) | | | | | |_  | |__| | | | (_| | |_) | | | |\n" +
                              " |_|   |___/|_|_| |_|___| |______|_| |__,_ | .__/|_| |_|\n" +
                              "                                           | |          \n" +
                              "  P r o d u c e d  b y  S u 1 t a n 0 5    |_|          \n");
            Console.WriteLine();
        }
        static double[] InputX() 
        {
            Console.WriteLine("Введите значения координат по х (через пробел)");
            string sax = Console.ReadLine();
            double[] ax = sax.Split().Select(p => Convert.ToDouble(p)).ToArray();
            return ax;
        }
        static double[] InputY()
        {
            Console.WriteLine("Введите значения координат по y (через пробел)");
            string say = Console.ReadLine();
            double[] ay = say.Split().Select(p => Convert.ToDouble(p)).ToArray();
            return ay;
        }
    }
}
