

using InterfaceLocadora.Entities;

namespace InterfaceLocadora.Services
{
    class RentalService // classe rece o objeto taxService e atribui a ele um valor 
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;   
        }
        public void ProcessInvoice(carRental carRental)
        {
            TimeSpan duration = carRental.finish.Subtract(carRental.start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                // math.ceilling - arrendoda as horas para cima 
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            // Com o pagamento báse e o imposto já possível associar as classes com as superclasses

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}

