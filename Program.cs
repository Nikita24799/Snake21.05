using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake21._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Point p1 = new Class_Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            Draw(p1.x, p1.y, p1.sym);

            Class_Point p2 = new Class_Point();
            p2.x = 4;
            p2.y = 5; 
            p2.sym = '#'; //ставим символы и создаем новую так скажем еду

            /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);*/

            /*int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);*/

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}