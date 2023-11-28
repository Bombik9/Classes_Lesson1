using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Lesson1
{

    class Rectangle
    {
        public double side1, side2;
        public double result;

        public Rectangle(double x, double y)
        {
            
            this.side1 = x;
            this.side2 = y;
        }



        public void AreaCalculator(double x, double y, double result)
        {
            result = x * y;
            Console.WriteLine($"Area = {result}см ");
        }
        public void PerimeterCalculator(double x, double y, double result)
        {
            result = (x + y) * 2;
            Console.WriteLine($"Perimetr = {result}см ");
        }
        public double Area
        {
            get { return result; }
        }
        public double Perimeter
        {
            get { return result; }
        }
    }


    //    Используя Visual Studio, создайте проект по шаблону Console Application.Требуется:
    //    Создать класс с именем Rectangle.
    //        В теле класса создать два поля, описывающие длины сторон double side1, side2. 
    //        Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов. 
    //        Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
    //        Создать два свойства double Area и double Perimeter с одним методом доступа get.
   
    //}


} 

