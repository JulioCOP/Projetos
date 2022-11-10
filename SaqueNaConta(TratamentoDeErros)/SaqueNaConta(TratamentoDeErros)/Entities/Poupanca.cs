using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using SaqueNaConta_TratamentoDeErros_.Entities.Exceptions;

namespace SaqueNaConta_TratamentoDeErros_.Entities
{
    class Poupanca
    {
        public int Numero { get; set; }
        public string Usuario { get; set; }

        public double Conta { get; set; }

        public double SaqueLimite { get; set; } 

        public Poupanca()
        {

        }
        public Poupanca(int numero, string usuario, double conta, double saqueLimite)
        {
            Numero = numero;
            Usuario = usuario;
            Conta = conta;
            SaqueLimite = saqueLimite;
        }   
        public void Deposito(double quantidade)
        {
            Conta += quantidade;
        }
        public void Saque(double quantidade)
        {
            if (quantidade> SaqueLimite)
            {
                throw new DomainException("A quantidade desejada excede o saque limite permitido"); 
            }
            if (quantidade> Conta)
            {
                throw new DomainException("Não possui saldo na conta");
            }
            Conta-=quantidade;
        } 
    }
}
