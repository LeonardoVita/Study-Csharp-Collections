using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class CsvReader
    {
        private string _csvReader;

        public CsvReader(string csvReader)
        {
            _csvReader = csvReader;
        }

        public Client[] ReadFirstNClients(int nClients)
        {
            Client[] client = new Client[nClients];

            using (StreamReader sr = new StreamReader(_csvReader))
            {
                //le a primeira linha que é o cabeçalho
                sr.ReadLine();

                for(int i = 0; i < nClients; i++)
                {
                    string Linha = sr.ReadLine();
                    client[i] = SplitLineAndCreateClient(Linha);
                }
            }
            return client;
        }

        public List<Client> ReadAllClients()
        {
            List<Client> clients = new List<Client>();

            using (StreamReader sr = new StreamReader(_csvReader))
            {
                //le a primeira linha que é o cabeçalho
                sr.ReadLine();
                string Linha;
                while((Linha = sr.ReadLine()) != null )
                {                    
                    clients.Add(SplitLineAndCreateClient(Linha));
                }
            }
            return clients;
        }

        public Client SplitLineAndCreateClient(string Line)
        {
            string[] LineSplited = Line.Split(',');
            string UserName = LineSplited[0];
            string FullName = LineSplited[1];
            string CPF = LineSplited[2];
            int Altura= int.Parse(LineSplited[3]);
            DateTime Nascimento = DateTime.Parse(LineSplited[4]);

            return new Client(UserName, FullName, CPF, Altura, Nascimento);
        }
    }
}
