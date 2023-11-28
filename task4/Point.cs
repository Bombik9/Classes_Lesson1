using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Point
    {
        string name;
        int a,b;

        public string Name
        {
            get { return name; }
        }
        public int A
        {
            get { return a; }
        }
        public int B
        {
            get { return b; }
        }

        public Point(string text, int a, int b)
        {
            this.name = text;
            this.a = a;
            this.b = b;
            
        }
    }
}
