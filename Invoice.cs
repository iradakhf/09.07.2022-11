using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Invoice
    {
       public int account;
       public string customer;
       public string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public Invoice()
        {

        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double CostCalculation ( bool needVat, double productValue, int Quantity)
        {  
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
