using POO_703.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_703
{
    internal class Program
    {

        static ClientService Clientes = new ClientService();
        static void Main(string[] args)
        {

            Console.WriteLine("Bienveidos\n");
            int opcion = 0;
            do
            {
                Console.WriteLine("Menu de opciones\n1. Clientes");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Clientes.navClient();
                        break;
                    default:
                        break;

                }
            } while (opcion != 6);


        }
    
    }
}
