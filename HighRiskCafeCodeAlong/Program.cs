using HighRiskCafeCodeAlong;

CoffeeMaker coffeeMaker = new();

foreach (string coffeeType in coffeeMaker.CoffeeTypes)
{
    Console.WriteLine(coffeeType);
}