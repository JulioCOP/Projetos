using ReservaHotel.Entities;
using ReservaHotel.Entities.Exceptions;
using System;


namespace ReservaHotel
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Room Number: ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                // Instanciar a classe Reservetion
                Reservation reservation = new Reservation(numQuarto, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.Write("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                // Chamada para atualização de datas

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation : " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}