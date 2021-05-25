using System;
using System.Collections.Generic;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\l.milanez.de.almeida\Documents\estudos\pluralsight\Csharp\collections\src\Clients.csv";

            CsvReader Reader = new CsvReader(FilePath);
            Client[] Clients = Reader.ReadFirstNClients(3);
            List<Client> ListClients = Reader.ReadAllClients();

            //Add new client into List
            Client lilliput = new Client("lilliput", "Liliane orleans","15445569965",162,DateTime.Now);
            int lilliputIndex = ListClients.FindIndex(x => x.UserName == "Escaper");
            ListClients.Insert(lilliputIndex+1, lilliput);
            //Remove DARK from the List
            ListClients.RemoveAt(ListClients.FindIndex(x => x.UserName == "DARK"));

            foreach(var client in ListClients)
            {
                Console.WriteLine($"UserName: {client.UserName}");
                Console.WriteLine($"FullName: {client.FullName}");
                Console.WriteLine($"CPF: {client.CPF}");
                Console.WriteLine($"Altura: {client.Altura}");
                Console.WriteLine($"Nascimento: {client.Nascimento}");
                Console.WriteLine($"\n================================\n");
            }

            Client Jose = new Client("lilliput", "José orleans", "45578998965", 172, DateTime.Now);
            Client Maria = new Client("lilliput", "Maria orleans", "35478332333", 160, DateTime.Now);

            Dictionary<string, Client> Dicionario = new Dictionary<string, Client>();

            Dicionario.Add(Jose.CPF, Jose);
            Dicionario.Add(Maria.CPF, Maria);

            Console.WriteLine($"\n|||||||||||||||||||||||||||||||||||||||||||||\n");

            foreach (var item in Dicionario)
            {
                Console.WriteLine($"       key: { item.Key}\nValue.Name: {item.Value.FullName}");
                Console.WriteLine($"\n|||||||||||||||||||||||||||||||||||||||||||||\n");
            }


        }
    }
}
