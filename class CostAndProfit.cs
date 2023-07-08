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
                    Console.WriteLine();

                    ArrangeOrderOfIncome();
                    return;
                }
                CalculateProductSales(choice);
            }
        }