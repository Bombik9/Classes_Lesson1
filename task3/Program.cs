using System.Reflection.Metadata;
using System.Text;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //    Требуется: Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
            //    Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
            //    Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.

            Console.OutputEncoding = Encoding.Unicode;

            Book book = new Book("Код да Вінчі");
            book.Author = "Жук Олег";
            book.Content = "І так воно було...";
            
           

            book.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}