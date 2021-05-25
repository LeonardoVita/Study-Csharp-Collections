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
            Client lilliput = new Client("lilliput", "Liliane orleans","15445569965",162,DateTime.Now);
            int lilliputIndex = ListClients.FindIndex(x => x.CPF == "47885665415");
            ListClients.Insert(lilliputIndex+1, lilliput);

            foreach(var client in ListClients)
            {
                Console.WriteLine($"UserName: {client.UserName}");
                Console.WriteLine($"FullName: {client.FullName}");
                Console.WriteLine($"CPF: {client.CPF}");
                Console.WriteLine($"Altura: {client.Altura}");
                Console.WriteLine($"Nascimento: {client.Nascimento}");
                Console.WriteLine($"\n================================\n");
            }

        }
    }
}
