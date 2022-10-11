using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplo1.Entities
{
    class BusinessAccount : Acount
    // Classe business account irá herda da classe acount
    {
        public double LoanLimit { get; set; }

        // Construtores básicos
        public BusinessAccount()
        {
        }
       // Construtor com argumentos
        public BusinessAccount(int numberCount, string holder, double balance, double loanLimit) : base(numberCount, holder, balance)   
        {
            // Acionar o contrutor do account para REUSO
            LoanLimit = loanLimit;    
        }
        public void Loan(double amount)
        // Realizar emprestimo
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
                            
        }
            
    }
}
