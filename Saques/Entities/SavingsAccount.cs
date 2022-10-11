using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplo1.Entities
{
    sealed class SavingsAccount : Acount
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }
        // Construtor com argumentos
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;    
        }
        // Método para atualizar o saldo da conta baseado na taxa de juros informada
        public void UpdateBalance()
        {
            Balance+= Balance*InterestRate;
        }
        //Função sobescrita
        public sealed override void Withdraw(double amount)
        // A função whitdraw, não pode ser herdada por uma futura subclasse elaborada - em caso de
        // a classe não for selada, somente a função selada não será herdada
        {
            //saque conforme a regra definida na superclasse Acount
            base.Withdraw(amount);
            // Retirada de + R$ 2,00 
            Balance -= 2.0;
        }
    }
}
