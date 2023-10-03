using HighRiskCafeCodeAlong;

CoffeeMaker coffeeMaker = new();

coffeeMaker.MakeCoffee();

if (coffeeMaker.newCoffee != null)
{
    Console.WriteLine(coffeeMaker.newCoffee!.GetInfo());

}


