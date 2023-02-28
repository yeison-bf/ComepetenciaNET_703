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
            Console.WriteLine("¿Desea llenar automaticamente los registros? 1. SI / 2. NO");
            int opcRegister = int.Parse(Console.ReadLine());

            if(opcRegister == 1)
            {
                seeders();
            }
            {
               
            }
            Console.Clear();
        }



        public void ListClients()
        {
            foreach(Clients cliente in listClients)
            {
                Console.Write(cliente);
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
            Console.WriteLine("Ingrese el id: ");
            int id = int.Parse(Console.ReadLine());
            foreach (var clients in listClients)
            {
                if (clients.Id == id)
                {
                    listClients.Remove(clients);
                    Console.WriteLine("Cliente eliminado exitosamente");
                    break;
                }
                else { Console.WriteLine("Cliente no encontrado"); }
            }
        }
    


        public void seeders()
        {
            listClients.Add(new Clients(1051890890, "Manuela", "Hoyos", "3211231234", "Br Aranjuez", "Medellin"));
            listClients.Add(new Clients(1051890891, "Katherin", "Hoyos", "31073838", "Br Aranjuez", "Medellin"));
            listClients.Add(new Clients(1051890892, "Kevi¿yn", "Hoyos", "316878939", "Br Aranjuez", "Medellin"));
            listClients.Add(new Clients(1051890893, "Jefferson", "Hoyos", "3211231234", "Br Aranjuez", "Medellin"));
            listClients.Add(new Clients(1051890894, "Camilo", "Hoyos", "3228939389", "Br Aranjuez", "Medellin"));
            listClients.Add(new Clients(1051890895, "Daniel", "Hoyos", "3102347876", "Br Aranjuez", "Medellin"));
            listClients.Add(new Clients(1051890896, "Cristian", "Hoyos", "3211231234", "Br Aranjuez", "Medellin"));
        }
    
    
    }
}
