using POO_703.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_703.Services
{
    public class ClientService
    {

        List<Clients> listClients = new List<Clients>();
        Clients client;
        public void navClient()
        {
            Console.WriteLine("Clientes\n");
            int opcion = 0;
            do
            {
                Console.WriteLine("\n1. Registrar\n2. Lstar\n3. Buscar\n4. Actualizar\n5. Eliminar \n 6.Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        RegisterClient();
                        break;
                    case 2:
                        ListClients();
                        break;
                    case 3:
                        SeacrhClient();
                        break;
                    case 4:
                        UpdateClient();
                        break;
                    case 5:
                        RemoverClient();
                        break;
                    case 6:
                        Console.WriteLine("Saliste de el sistema");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcion != 6);
            
        }


        public void RegisterClient()
        {
            Console.WriteLine("Información del cliente\n");

            Console.WriteLine("Identificación");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre");
            string name = Console.ReadLine();

            Console.WriteLine("Apellidos");
            string lastname = Console.ReadLine();

            Console.WriteLine("Ciudad");
            string city = Console.ReadLine();

            Console.WriteLine("Localidad");
            string location = Console.ReadLine();

            Console.WriteLine("Telefono");
            string phone = Console.ReadLine();

            listClients.Add(new Clients(id,name, lastname, city, location, phone));

            Console.Clear();
            ListClients();
        }



        public void ListClients()
        {
            foreach(Clients cliente in listClients)
            {
                Console.Write(cliente.ToString());
            }
        }



        public void SeacrhClient()
        {
            Console.WriteLine("Ingrese el id: ");
            int id = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var clients in listClients)
            {
                if (clients.Id == id)
                {
                    count++;
                    Console.WriteLine(clients);
                    break;
                }
            }
            if(count!=1){
                 Console.WriteLine("Cliente no encontrado");
            }
 
        }


        public void UpdateClient()
        {

        }


        public void RemoverClient()
        {

        }
    }
}
