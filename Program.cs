using System;
namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoice invoice = new Invoice("1542", "Ird", "SuperMarket");

            //invoice.Article = "LapTop";
            //invoice.Article = "USB";
            invoice.Article = "SD Card";
            //invoice.Article = "USB";
            //invoice.Article = "SD Card";
            invoice.Quantity = 2;
            //invoice.Quantity = 1;
            //invoice.Quantity = 12;

            Console.WriteLine($"{invoice.Quantity} {invoice.Article} : {invoice.CostCalculation(true)} AZN ");
        }

    }
}
