using System;
using System.Globalization;

namespace lista_nomes.Entities
{
    class Players : IComparable
    {
        public string Name { get; set; }

        public string IssuingAgency { get; set; }
        public double Identify { get; set; }

        public Players( string csvPlayers)
        {
            string[] vet = csvPlayers.Split(',');
            Name = vet[0];
            IssuingAgency = vet[1];
            Identify = double.Parse(vet[2], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + " , "  + IssuingAgency + Identify.ToString(CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) // comparar dois objetos dentro de uma lista, para que um venha em ordem
                                         // crescente ou de acordo com o tamanho ou valor dado
        {
            if(!(obj is Players))
            {
                throw new ArgumentException("Compareing error: argument is not a player");
            }
            Players otherPlayers = obj as Players;
            return Name.CompareTo(otherPlayers.Name);
        }
    }
}
