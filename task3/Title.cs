using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Title
    {
       string text;

        public string Text
        {
            private get
            {
                if (text != null)
                    return text;
                else
                    return "Відсутні данні";
            }
            set
            {
                text = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
