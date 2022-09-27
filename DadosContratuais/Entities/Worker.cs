using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DadosContratuais.Entities.Enums;

namespace DadosContratuais.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        
        // Salário base de todo funcionário
        public double BaseSalary { get; set; }

        // Propriedade com composição de objetos
        public Department Department { get; set; }
        // A variavel é do mesmo tipo da classe

        // Criada um propriedade chamada de contratos, devido a assoiação entre as classes

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        // De acordo com diagrama, são varios contratos, por isso, usa-se o comando Lista

        // Construtores:

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Implementar os metodos de acordo com os passados no diagrama UML
        public void AddContract(HourContract contract)
        {
            // Adiconar na lista Contracts o parametro contract

            Contracts.Add(contract);
        }
        // Se tem uma operação para adicionar um contrato, tem que ter uma para remover o contrato
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        //Implementar a ultima operação, no caso, income(ganho)

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            // Trabalhador ganha seu salario base
            foreach(HourContract contract in Contracts)
            // A partir dai, o programa percorre a lista de contratos, dos trabalhos realizados pelo trabalhador
            {
                if (contract.Data.Year== year && contract.Data.Month == month)
                // Se o ano e o mes do contrato, forem iguais as datas recebidos como argumento, através do usuário, então ocorrer a somatória desse salario
                {
                    sum += contract.TotalValue(); 
                    // TotalValeu é a operação que retorna o valor do contrato
                }
            }
            return sum; 
            // no final é retornado o valor total desse contrato em caso d condicional ser atendida
        }
    }
}
