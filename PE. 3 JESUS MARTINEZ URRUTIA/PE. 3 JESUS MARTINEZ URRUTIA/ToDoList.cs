using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE._3_JESUS_MARTINEZ_URRUTIA
{
    public class ToDoList
    {
        List<ToDo> SinHacer = new List<ToDo>();//Lista de tareas sin empezar
        List<ToDo> Durante = new List<ToDo>();//Lista de tareas empezadas
        List<ToDo> Fin = new List<ToDo>();//Lista de tareas acabadas
        public void VerTareas()//Metodo para ver tareas
        {
            Console.WriteLine("Cosas Pendientes");
            foreach (var item in SinHacer)//Imprime las tareas sin empezar
            {
                Console.WriteLine("Tarea:" + item.Num);
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Descripcion: " + item.QuéHacer);
                Console.WriteLine("Fecha Inicio: " + item.Inicio);
                Console.WriteLine("Estado: " + item.Fin);

            }
            Console.WriteLine("Cosas En Proceso ");
            foreach (var item in Durante)//Imprima las tareas ya empezadas
            {
                Console.WriteLine("Tarea:" + item.Num);
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Descripcion: " + item.QuéHacer);
                Console.WriteLine("Fecha Inicio: " + item.Inicio);
                Console.WriteLine("Estado: " + item.Fin);
            }
            Console.WriteLine("Cosas Terminados");
            foreach (var item in Fin)//Imprime loas tareas finalizadas
            {
                Console.WriteLine("Tarea:" + item.Num);
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Descripcion: " + item.QuéHacer);
                Console.WriteLine("Fecha Inicio: " + item.Inicio);
                Console.WriteLine("Estado: " + item.Fin);
            }
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }
        public void AgregarTarea()//Metodo para agregar tareas
        {
            ToDo Tarea = new ToDo();
            Console.WriteLine("Ingrese el numero de la tarea: ");
            Tarea.Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la tarea: ");
            Tarea.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese una descripcion : ");
            Tarea.QuéHacer = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha en que se deja la tarea: ");
            Tarea.Inicio = int.Parse(Console.ReadLine());
            SinHacer.Add(Tarea);//Agrega los elementos
        }
        public void Menu()
        {
            int Op;
            do
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("1. Ver");
                Console.WriteLine("2.Agregar");
                Console.WriteLine("3.??");
                Console.WriteLine("4. Salir");
                Op = int.Parse(Console.ReadLine());
                switch (Op)
                {
                    case 1:
                        VerTareas();//Revisa las tareas
                        break;
                    case 2:
                        AgregarTarea();//Agrega las tareas
                        break;
                    case 3:
                        Console.WriteLine("Por falta de tiempo y de conocimiento (flojera) no puede realizar el cambio de tarea (Pendiente, Empezado, Finalizado");
                        break;
                }
            } while (Op < 4);
        }
    }
}
