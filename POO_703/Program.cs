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
        static UserSevice User = new UserSevice();

        static void Main(string[] args)
        {
            User.seeders();
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Bienvenido\n");
            bool siExiste = false;
            do
            {
                Console.WriteLine("*************************\nUsuario");
                string email = Console.ReadLine();
                Console.WriteLine("Password");
                string password = Console.ReadLine();
                Console.WriteLine("*************************");

                if(!User.login(email, password))
                {
                    Console.WriteLine("*************************\nOpp! Credenciales incorrectas");
                    Console.WriteLine("¿Desea crear una cuenta 1. SI / 2. NO");
                    int opcionRegistro = int.Parse(Console.ReadLine());
                    if(opcionRegistro == 1)
                    {
                        User.RegisterUsers();
                    }
                    Console.WriteLine("*************************");
                }
                else
                {
                    siExiste = true;
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

           
            } while (!siExiste);


        }

    }
}
