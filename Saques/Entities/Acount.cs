using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplo1.Entities
{
    class Acount
    {
        // Private = permite o acesso a variavel de acesso a conta para este projeto. Porém como o acesso é privativo E NÃO se pode alterar o valor
        public int Number{ get; private set; }
        public string Holder { get; private set; } // titular
        public double Balance  { get; protected set; } // saldo da conta

        public Acount()
        {

        }
        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        // Função para realizar saque da conta
        public virtual void Withdraw(double amount)
            // Função recebe como parâmetro uma parâmetro chamado "amount" que seria o montante da conta
            // Função de retirada de dinheiro sobescrito  
        {
            Balance -= amount + 5.0;  
        }
        public void Deposit(double amount)
        // Função de deposito para a conta 
        {
            Balance += amount;
        }
    }
}
