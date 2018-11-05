using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._3_JESUS_MARTINEZ_URRUTIA
{
    class Program
    {
        static void Main(string[] args)
        {
            PraEv o = new PraEv();
            ToDoList t = new ToDoList();
            o.Vacas();
            o.Hanoi();
            t.Menu();
            Console.ReadKey();
        }
    }
}
