using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Discount_Program_For_Customers
{
    internal class Program
    {
        const double discount = 0.09;
        static void Main(string[] args)
        {
            Console.Write("Enter the amount due :");
            double amount= double.Parse(Console.ReadLine());
            Console.Write("Enter the age :");
            int Age=int.Parse(Console.ReadLine());
            if(Age<=25 && amount > 150)
            {
                double TotalDiscount=amount*discount;
                double totalAmount=amount-TotalDiscount;
                Console.WriteLine("You qualify for a discount amount of {0:C} and owes {1:C}",TotalDiscount,totalAmount);
            }
            else
            {
                Console.WriteLine("You do not qualify for discount,and owes {0:C}", amount) ;
            }
            Console.ReadLine(); 
            
        }
    }
}
