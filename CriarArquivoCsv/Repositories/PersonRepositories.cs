using System.Collections.Generic;
using CriarArquivoCsv.Models;

namespace CriarArquivoCsv.Repositories
{
    // Cria��o de um repsit�rio da onde os dados ser�o buscados
    public static class PersonRepository
    {
        public static List<PersonModel> GetPeople()
        {
            return new List<PersonModel> //Adicionando os dados das pessoas dentro da lista
            {
                new PersonModel
                {
                    Document = "688.414.350-97",
                    Name = "João"
                },
                new PersonModel
                {
                    Document = "327.475.870-10",
                    Name = "Alan"
                },
                new PersonModel
                {
                    Document = "177.262.600-76",
                    Name = "Maria"
                },
                new PersonModel
                {
                    Document = "584.782.720-20",
                    Name = "Lilian"
                }
            };
        }
    }
}
            
