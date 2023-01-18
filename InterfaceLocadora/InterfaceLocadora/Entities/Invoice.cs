using System;
using System.Globalization;

namespace InterfaceLocadora.Entities
{
    class Invoice
    {
        public double basicPayment { get; set; }

        public double tax { get; set; }

       
        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
        }
        
        //Propriedade calculada
        public double totalPayment
        {
            get { return basicPayment + tax; }
        }

        public override string ToString()
        {
            return "Base payment: "
                + basicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + totalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
