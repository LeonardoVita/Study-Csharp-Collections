using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\l.milanez.de.almeida\Documents\estudos\pluralsight\Csharp\collections\src\Clients.csv";

            CsvReader reader = new CsvReader(FilePath);
            Client[] clients = reader.ReadFirstNClients(4);


            foreach(var client in clients)
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
