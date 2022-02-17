using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Posiciones
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[,] equipos = new  string[3, 2];
            for (int i = 0; i < equipos.GetLength(0); i++)
            {
                Console.WriteLine("----------->TABLA DE POSICIONES DE EQUIPOS DE FUTBOL<-----------");

                Console.WriteLine(" Ingrese equipos: " + (i + 1));
                equipos[i, 0] = Console.ReadLine();
                Console.WriteLine(" Ingrese Puntajes: " + (i + 1));
                equipos[i, 1] = Console.ReadLine();
            }

            Console.WriteLine(" Ingrese el puntaje que quiere ver: ");
            string Puntaje = Console.ReadLine();
            for (int i = 0; i < equipos.GetLength(0); i++)
            {
                if (equipos[i, 1] == Puntaje)
                {  
                    Console.Write(equipos[i,0]);
                    Console.Write(" | "+equipos[i,1]);
                    
                    //for (int j = 0; j < equipos.GetLength(1); j++)
                    //{
                    //    Console.WriteLine(equipos[i, j] + " | ");
                    //}
                }
                //Console.WriteLine();
            }
            Console.Read();
        }
    }
}

