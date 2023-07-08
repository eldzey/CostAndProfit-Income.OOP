using System;
using System.Collection.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    class Product
    {
        public string Name { get; }
        public double Cost { get; }
        public double SellingPrice { get; }

        public Product(string name, double cost, double SellingPrice)
        {
            Name = name;
            Cost = cost;
            SellingPrice = sellingPrice;
        }

        public double CalculateExpenses(int quantity)
        {
            return quantity * Cost;
        }

        public double CalculateSales(int quantity)
        {
            return quantity * SellingPrice;
        }

        public double CalculateIncome(int quantity)
        {
            double totalSales = CalculateSales(quantity);
            double totalExpenses = CalculateExpenses(quantity);
            return totalSales - totalExpenses;
        }
    }

    class CostAndProfit
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine()
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    //Console.WriteLine();

                    ArrangeOrderOfIncome();
                    return;
                }
                CalculateProductSales(choice);
            }
        }

        static void CalculateProductSales(int choice)

        static Product GetProduct(int choice)

        static void ArrangeOrderOfIncome()


    }
}