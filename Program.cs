using System;
namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Invoice();
            obj.Article="LapTop";
            //obj.Article = "SD Card";
            //obj.Article = "USB";
           
           
            Invoice invoice = new Invoice(1254, "Ird", "SuperMarket");
            
           
            double cost = 0;
            if (obj.Article == "LapTop")
            {   cost = obj.CostCalculation(true, 1200, 4);
                Console.WriteLine($"{ invoice.account}: { invoice.customer}: { invoice.provider}");
                Console.WriteLine($"{obj.Article} : {cost} azn");
            }    
            else if (obj.Article== "SD Card")
            {
                cost = obj.CostCalculation(true, 30, 2);
                Console.WriteLine($"{cost} {invoice}");
            }
            else
            {
                cost = obj.CostCalculation(false, 12, 1);
                Console.WriteLine($"{cost} {invoice}");
            }

        }
    }
}
