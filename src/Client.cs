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
        public string Gender;
        public DateTime Nascimento;

        public Client(string userName, string fullName, string cpf, int altura, string gender, DateTime nascimento)
        {
            UserName = userName;
            FullName = fullName;
            CPF = cpf;
            Altura = altura;
            Nascimento = nascimento;
            Gender = gender;
        }
    }
}
