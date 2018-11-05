using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._3_JESUS_MARTINEZ_URRUTIA
{
    public class PraEv
    {
        public void Vacas()
        {
            Console.WriteLine("1.- Supongamos que Bob tiene cuatro vacas que quiere cruzar por un puente, " +
                "pero solo un yugo, que puede sostener hasta dos vacas, lado a lado, atadas al yugo. " +
                "El yugo es demasiado pesado para que lo lleve a través del puente, pero puede atar (y desatar) " +
                "vacas a él en muy poco tiempo. De sus cuatro vacas, Mazie puede cruzar el puente en 2 minutos, " +
                "Daisy puede cruzarlo en 4 minutos, Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos. " +
                "Por supuesto, cuando dos vacas están atadas al yugo, deben ir a la velocidad de la vaca más lenta. " +
                "Describe cómo Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos.");//Problema
            List<string> Inicio = new List<string>();//Lista para inicio del puente
            List<string> Final = new List<string>();//Lista para el final del puente
            int cont = 0;//Contador para contar y sumar el tiempo transcurrido
            int min;//Toma en cuenta el tiempo de la vaca mas lenta
            Inicio.Add("Lazy = 20 minutos");//Se agregan las vacas con su tiempo 
            Inicio.Add("Crazy = 10 minutos");
            Inicio.Add("Daisy = 4 minutos");
            Inicio.Add("Mazie = 2 minutos");
            Console.ReadKey();
            Console.Clear();//Se elimina la consola
            Console.WriteLine("Inicio:");
            foreach (var item in Inicio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Fin");
            foreach (var item in Final)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("El tiempo transcurrido es de " + cont + " minutos");
            Console.ReadKey();//Se imprime los contenidos de la lista en cada foreach
            Console.Clear();
            Inicio.Remove("Mazie = 2 minutos");//Se eliminan de la lsita
            Inicio.Remove("Daisy = 4 minutos");
            Final.Add("Mazie = 2 minutos");//Y se agregan al final
            Final.Add("Daisy = 4 minutos");

            Console.WriteLine("Inicio:");
            min = 4;
            cont += min;
            foreach (var item in Inicio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Fin");
            foreach (var item in Final)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("El tiempo transcurrido es de " + cont + " minutos");
            Console.ReadKey();//Imprime las listas actualizadas
            Console.Clear();
            Final.Remove("Daisy = 4 minutos");
            Inicio.Add("Daisy = 4 minutos");
            Console.WriteLine("Inicio:");
            min = 4;
            cont += min;
            foreach (var item in Inicio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Fin");
            foreach (var item in Final)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("El tiempo transcurrido es de " + cont + " minutos");
            Console.ReadKey();
            Console.Clear();
            Inicio.Remove("Lazy = 20 minutos");
            Inicio.Remove("Crazy = 10 minutos");
            Final.Add("Lazy = 20 minutos");
            Final.Add("Crazy = 10 minutos");
            Console.WriteLine("Inicio:");
            min = 20;
            cont += min;
            foreach (var item in Inicio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Fin");
            foreach (var item in Final)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("El tiempo transcurrido es de " + cont + " minutos");
            Console.ReadKey();
            Console.Clear();
            Final.Remove("Mazie = 2 minutos");
            Inicio.Add("Mazie = 2 minutos");
            Console.WriteLine("Inicio:");
            min = 2;
            cont += min;
            foreach (var item in Inicio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Fin");
            foreach (var item in Final)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("El tiempo transcurrido es de " + cont + " minutos");
            Console.ReadKey();
            Console.Clear();
            Inicio.Remove("Mazie = 2 minutos");
            Inicio.Remove("Daisy = 4 minutos");
            Final.Add("Mazie = 2 minutos");
            Final.Add("Daisy = 4 minutos");
            Console.WriteLine("Inicio:");
            min = 4;
            cont += min;
            foreach (var item in Inicio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Fin");
            foreach (var item in Final)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("El tiempo transcurrido es de " + cont + " minutos");
            Console.ReadKey();
            Console.Clear();
        }
        public void Hanoi()
        {
            Stack<int> n1Torre = new Stack<int>();//Se crea la torre 1
            Stack<int> n2Torre = new Stack<int>();//Se crea la torre 2
            Stack<int> n3Torre = new Stack<int>();//Se crea la torre 3
            Console.WriteLine("Ingresa la cantidad de Discos");
            int Discs = int.Parse(Console.ReadLine());
            for (int i = Discs; i > 0; i--)
            {
                n1Torre.Push(i);
            }
            Hanois H = new Hanois();
            H.Metodo(Discs, n1Torre, n2Torre, n3Torre);
            H.Imprimir(n1Torre, n2Torre, n3Torre);
        }
    }
}
