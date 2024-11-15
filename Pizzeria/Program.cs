using System;
using System.Collections.Generic;
using Pizzeria;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите тип пиццерии: \n1 - Итальянская\n 2 - Нью-Йорк\n 3 - Веганская\n");
       
        string pizzeriaType = Console.ReadLine();

        PizzaFactory factory = pizzeriaType switch
        {
            "1" => new ItalianPizzaFactory(),
            "2" => new NewYorkPizzaFactory(),
            "3" => new VeganPizzaFactory()
        };

        var system = new PizzaOrder(factory);

        Console.WriteLine("Выберите размер пиццы: Маленькая, Средняя, Большая");
        string size = Console.ReadLine();

        var pizza = system.CreateOrder(size);

        Console.WriteLine($"Ваш заказ: {pizza.GetDescription()}");
    }
}