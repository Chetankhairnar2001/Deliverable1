using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the restocking tool.");
        int soda_stock_val = 100, chips_stock_val = 40, candy_stock_val = 60;
        int soda_restock_val = 40, chips_restock_val = 20, candy_restock_val = 40;
        int val = 0;

        Console.WriteLine("How many Sodas have been sold today? " + soda_stock_val + " are in stock");
        val = int.Parse(Console.ReadLine());
        if (val > soda_stock_val)
            Console.WriteLine("That value is too high. Stock not adjusted");
        else
        {
            soda_stock_val -= val;
            Console.WriteLine("There are " + soda_stock_val + " Sodas left");
        }

        Console.WriteLine("How many Chips have been sold today ? " + chips_stock_val + " are in stock");
        val = int.Parse(Console.ReadLine());
        if (val > chips_stock_val)
            Console.WriteLine("That value is too high. Chips not adjusted");
        else
        {
            chips_stock_val -= val;
            Console.WriteLine("There are " + chips_stock_val + " Chips left");
        }

        Console.WriteLine("How many Candy have been sold today? " + candy_stock_val + " are in stock");
        val = int.Parse(Console.ReadLine());
        if (val > candy_stock_val)
            Console.WriteLine("That value is too high. Candy not adjusted");
        else
        {
            candy_stock_val -= val;
            Console.WriteLine("There are " + candy_stock_val + " Candy left");
        }

        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
        if (soda_stock_val < soda_restock_val)
            Console.WriteLine("Soda needs to be restocked");
        if (chips_stock_val < chips_restock_val)
            Console.WriteLine("Chips needs to be restocked");
        if (candy_stock_val < candy_restock_val)
            Console.WriteLine("Candy needs to be restocked");

    }
}