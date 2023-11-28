using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Book
    {
        Title title = null;
        Author author = null;
        Content content = null;

        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }

        public Book(string title)
        {
            InitializeBook();
            this.title.Text = title;
        } 

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

        public string Author
        {
            set
            {
                this.author.Text = value;
            }

        }

        public string Content
        {
            set
            {
                this.content.Text = value;
            }
        }

        //Используя Visual Studio, создайте проект по шаблону Console Application. 
        //    Требуется: Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
        //    Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
        //    Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.


    }
}
