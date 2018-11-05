using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._3_JESUS_MARTINEZ_URRUTIA
{
    public class Hanois//Metodo hecho en otra clase para hacer espacio
    {

        public void Metodo(int Discos, Stack<int> Torre1, Stack<int> Torre2, Stack<int> Torre3)
        {
            Imprimir(Torre1, Torre2, Torre3);//Imprime el contenido de las torres
            if (Discos == 1)//
            {
                Torre3.Push(Torre1.Pop());//Agrega el primer elemento de la torre 1 al 3 y lo borra
            }
            else
            {
                Metodo(Discos - 1, Torre1, Torre3, Torre2);
                Imprimir(Torre1, Torre2, Torre3);
                Metodo(1, Torre1, Torre2, Torre3);
                Imprimir(Torre1, Torre2, Torre3);
                Metodo(Discos - 1, Torre2, Torre1, Torre3);
            }
            Imprimir(Torre1, Torre2, Torre3);
        }
        public void Imprimir(Stack<int> n1Torre, Stack<int> n2Torre, Stack<int> n3Torre)
        {
            int cont = 1;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Torre número 1");
            foreach (var item in n1Torre)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Torre número 2");
            foreach (var item in n2Torre)
            {
                Console.WriteLine(item);
                cont++;
            }
            cont = 1;
            Console.WriteLine("Torre número 3");
            foreach (var item in n3Torre)
            {
                Console.WriteLine(item);
                cont++;
            }

        }
    }
}
