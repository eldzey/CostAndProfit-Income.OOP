using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n-------------------------------------- ");
            Console.WriteLine("\nChoose a product to compute sales. ");
            Console.WriteLine("Enter 1: Fries ");
            Console.WriteLine("Enter 2: Potato Roll ");
            Console.WriteLine("Enter 3: Cheese Stick ");
            Console.WriteLine("Enter 4 to arrange the order of income. ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 4)
            {
            Console.WriteLine("\nSuccessfully left the product choices. ");
            ArrangeOrderOfIncome();
            return;
            }
            CalculateProductSales(choice);
        }
    }

    static void CalculateProductSales(int choice)
    {
        Product product = GetProduct(choice);
        Console.WriteLine(product.Name);


        Console.Write("Enter the number of product: ");
        int numOfProduct = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the cost of the product: ");
        double productCost = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the selling price: ");
        double sellingPrice = Convert.ToDouble(Console.ReadLine());

        double totalExpenses =numOfProduct * productCost;
        double totalSales = numOfProduct * sellingPrice;
        double totalIncome = totalSales - totalExpenses;

        Console.WriteLine("Total Expenses: Php " + totalExpenses);
        Console.WriteLine("Total Revenue: Php " + totalSales);
        Console.WriteLine("\nTotal Profit: Php " + totalIncome);

        if(totalSales > totalExpenses)
        Console.WriteLine("You have earned net income. ");
        else
        Console.WriteLine("This product sales reuslt in a loss. ");
    }

    static Product GetProduct(int choice)
    {
        switch (choice)
        {
            case 1:
            return new Product("\n----------------FRIES----------------IES", 0.0, 0.0);
            case 2:
            return new Product("\n--------------POTATO ROLL--------------", 0.0, 0.0);
            case 3:
            return new Product("\n-------------CHEESE STICK------------", 0.0, 0.0);
            default:
            return null;
        }
    }

    static void ArrangeOrderOfIncome()
    {
        List<string> income = new List<string>();
        Console.WriteLine("Type the value of total income and name of product then type 'done' to arrange the order of profits. ");
        Console.WriteLine("*Use NUMBER and SMALL LETTER only* ");
        string incomeInput = Console.ReadLine();

        while (incomeInput != "done")
        {
            income.Add(incomeInput);
            incomeInput = Console.ReadLine();
        }

        Console.WriteLine("\nCongratulations, this is the list of products from most profitable to the least profitable. ");
        income.Reverse();

        foreach (string item in income)
        {
            Console.WriteLine(item);
        }
    }
}
