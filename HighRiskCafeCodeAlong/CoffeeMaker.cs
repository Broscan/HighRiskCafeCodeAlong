namespace HighRiskCafeCodeAlong
{
    internal class CoffeeMaker
    {

        private List<string> _coffeeTypes = new() { "Espresso", "Macchiato", "Cortado", "Mocha", "Americano", "Cappuccino" };

        public void MakeCoffee()
        {
            string? response = AskForCoffee();

            if (response == "y")
            {
                Coffee newCoffee = new(AskForCoffeeType());

                Console.WriteLine($"Starting to make {newCoffee}...");

                PutCoffeeInMachine();

            }
            else
            {

            }
        }

        private string? AskForCoffee()
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Do you want a coffee?");
                Console.WriteLine("Type \"y\" for yes, \"n\" for no");
                Console.Write("Response: ");
                string? response = Console.ReadLine()?.ToLower();

                if (response == "y" || response == "n")
                {
                    return response;
                }

            }


        }

        private string AskForCoffeeType()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("What type of coffee do you want?");
                Console.WriteLine("We have: ");
                Console.WriteLine();
                foreach (string coffeeType in _coffeeTypes)
                {
                    Console.WriteLine(coffeeType);
                }
                Console.WriteLine();

                Console.Write("Response: ");
                string? response = Console.ReadLine()?.ToLower();

                foreach (string coffeeType in _coffeeTypes)
                {
                    if (response == coffeeType.ToLower())
                    {
                        return coffeeType;
                    }
                }

                Console.WriteLine("Sorry, we don't have that Coffee");
                Presskey();

            }
        }

        private void Presskey()
        {
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
        }

        private void ValidateCoffeeType()
        {


        }

        private void DetermineSuccess()
        {

        }

        private void PutCoffeeInMachine()
        {
            Console.WriteLine("Attempting to put coffee in machine...");
            if (DetermineSuccess())
            {
                // Lyckas
            }
            else
            {
                // Misslyckas            
            }

        }

        private void PutWaterInMachine()
        {

        }

        public void PutCupInMachine()
        {

        }

        public void StarMachine()
        {

        }

        private void ServeCoffeeToGuest()
        {

        }


    }
}
