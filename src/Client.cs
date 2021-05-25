using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Client
    {
        public string UserName;
        public string FullName;
        public string CPF;
        public int Altura;
        public DateTime Nascimento;

        public Client(string userName, string fullName, string cPF, int altura, DateTime nascimento)
        {
            UserName = userName;
            FullName = fullName;
            CPF = cPF;
            Altura = altura;
            Nascimento = nascimento;
        }
    }
}
