using System;
using System.Collections.Generic;
using System.Linq;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\l.milanez.de.almeida\Documents\estudos\pluralsight\Csharp\collections\src\Clients.csv";
            CsvReader Reader = new CsvReader(FilePath);

            Client[] ArrayClients = Reader.ReadFirstNClients(3);
            List<Client> ListClients = Reader.ReadAllClients();

            AddDeleteExample(ListClients);

            //ForEachPrint(ListClients);

            //ForEachPrint(ArrayClients);

            ForLoopPrint(ListClients);

            //ForLoopPrint(ArrayClients);

            DictionaryExample();

        }

        public static void PrintClients(Client client)
        {
            Console.WriteLine($"UserName: {client.UserName}");
            Console.WriteLine($"FullName: {client.FullName}");
            Console.WriteLine($"CPF: {client.CPF}");
            Console.WriteLine($"Altura: {client.Altura}");
            Console.WriteLine($"Nascimento: {client.Nascimento}");
            Console.WriteLine($"\n================================\n");
        }
        public static void DictionaryExample()
        {
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
        public static void AddDeleteExample(List<Client> ListClients)
        {
            //Add new client into List
            Client lilliput = new Client("lilliput", "Liliane orleans", "15445569965", 162, DateTime.Now);
            int lilliputIndex = ListClients.FindIndex(x => x.UserName == "Escaper");
            ListClients.Insert(lilliputIndex + 1, lilliput);
            //Remove DARK from the List
            ListClients.RemoveAt(ListClients.FindIndex(x => x.UserName == "DARK"));
        }
        public static int ReadUsersSizePerPage()
        {
            Console.WriteLine("Digite o numero de Usuarios que deseja ver>");
            bool InputIsInt = int.TryParse(Console.ReadLine(), out int UsersInt);

            if (!InputIsInt || UsersInt <= 0)
            {
                Console.WriteLine("Numero digitado é invalido!");
                throw new Exception("Numero digitado é invalido!");
            }

            return UsersInt;
        }
        public static void ForEachPrint(List<Client> ListClients)
        {
            foreach (var client in ListClients)
            {
                PrintClients(client);
            }
        }
        public static void ForEachPrint(Client[] ListClients)
        {
            foreach (var client in ListClients)
            {
                PrintClients(client);
            }
        }
        public static void ForLoopPrint(List<Client> ListClients)
        {
            int UsersInt = ReadUsersSizePerPage();
            int MaxToDisplay = UsersInt;

            for (int i = 0; i < ListClients.Count; i++)
            {
                if (i > 0 && (i % MaxToDisplay == 0))
                {
                    Console.WriteLine("Click ENTER para continuar ou qualquer outra coisa para sair");
                    if (Console.ReadLine() != "")
                        break;
                }
                PrintClients(ListClients[i]);
            }
        }
        public static void ForLoopPrint(Client[] ListClients)
        {
            int UsersInt = ReadUsersSizePerPage();
            int MaxToDisplay = UsersInt;
            for (int i = 0; i < ListClients.Length; i++)
            {
                if (i > 0 && (i % MaxToDisplay == 0))
                {
                    Console.WriteLine("Click ENTER para continuar ou qualquer outra coisa para sair");
                    if (Console.ReadLine() != "")
                        break;
                }
                PrintClients(ListClients[i]);
            }
        }
    }
}
