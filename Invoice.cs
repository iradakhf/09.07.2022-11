using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Invoice
    {
       private string account;
       private string customer;
       private string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public Invoice()
        {

        }
        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double CostCalculation ( bool needVat)
        {
            double productValue;
            
            if (Article == "LapTop")
            {
                productValue = 1200;
            }
            else if (Article == "USB")
            {
                productValue = 12;
            }
            else
            {
                productValue = 30;
            }
            double vat = productValue* 0.18;
            if (needVat == true)
            {
                productValue = productValue * Quantity + vat;
            }
            else
            {
                productValue *= Quantity;
            }
            return productValue;
        }
    }
}
