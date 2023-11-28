using System.Drawing;
using System.Text;

namespace Classes_Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //Для корректного використання укр. мови
            Console.InputEncoding = Encoding.Unicode;

            //        Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. 
            double result = 0;

            Console.WriteLine("Введіть першу сторону прямокутника: ");
            double firstSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть другу сторону прямокутника: ");
            double secondSide = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(firstSide, secondSide);
            Console.WriteLine($" Перша сторона {firstSide}см друга сторона {secondSide}см ");

            Rectangle rectangle1 = new Rectangle(firstSide,secondSide);
            rectangle1.AreaCalculator(firstSide, secondSide, result);
            
            Rectangle rectangle2 = new Rectangle(secondSide, firstSide);
            rectangle2.PerimeterCalculator(firstSide, secondSide, result);

       

            // Delay.
            Console.ReadKey();

        }
    }
}