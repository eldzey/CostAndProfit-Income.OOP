using System;
using System.Linq;
using System.Collections.Generic;

public static class Expenses
{
    public static double CalculateExpenses(Product product, int quantity)
    {
        return quantity * product.Cost;
    }
}