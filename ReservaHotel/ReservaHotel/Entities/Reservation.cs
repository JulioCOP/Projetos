using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaHotel.Entities.Exceptions;


namespace ReservaHotel.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                // throw - substitui o return e além disso realiza o lançamento de um nova exceção
                throw new DomainException("Check-out date must be after chek-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }   
        public double Duration()
        {
            // Duraç da reserva -  Fazer a diferença entre ambas as datas.

            TimeSpan duration = CheckOut.Subtract(CheckIn);
            // TotalDays é uma função que retorna em double
            // (int)Função -> castinh para que o comando retorne como inteiro
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                // throw - substitui o return e além disso realiza o lançamento de um nova exceção e corta toda método caso caia dentro do erro
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        // Necessário faer o ToString da reserva ->  Impressão dos formatos de acordo com que é adotado como padrão
        public override string ToString()
        {
            return "Room" +
                RoomNumber +
                " , check-in: "+
                CheckIn.ToString("dd/MM/yyy") +
                ", check-out: " +
                CheckOut.ToString("dd/MM/yyy") +
                " , " +
                Duration() +
                " nights";
        }

    }
}
