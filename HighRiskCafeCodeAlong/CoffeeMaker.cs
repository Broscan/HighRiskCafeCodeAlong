namespace HighRiskCafeCodeAlong
{
    internal class CoffeeMaker
    {

        private List<string> _coffeeTypes = new() { "Espresso", "Macchiato", "Cortado", "Mocha", "Americano", "Cappuccino" };

        public Coffee? newCoffee { get; set; }

        public void MakeCoffee()
        {
            string? response = AskForCoffee();

            if (response == "y")
            {
                newCoffee = new(AskForCoffeeType());

                Console.WriteLine($"Starting to make {newCoffee}...");

                PutCoffeeInMachine();

                //if (!string.IsNullOrEmpty(newCoffee.FailedStep))
                //{
                //    Console.WriteLine(newCoffee.FailedStep);
                //}
                Console.WriteLine(newCoffee!.GetInfo());
            }
            else
            {
                Console.WriteLine("Nähä, skit i det då.");
                Presskey();
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



        private bool DetermineSuccess()
        {
            int randomNumber = new Random().Next(1, 101);

            if (randomNumber <= 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void PutCoffeeInMachine()
        {
            Console.WriteLine("Attempting to put coffee in machine...");

            Thread.Sleep(1000);

            if (DetermineSuccess())
            {
                // Lyckas
                Console.WriteLine("Putting coffee in machine successfull!");
                PutWaterInMachine();
            }
            else
            {
                // Misslyckas
                newCoffee!.FailedStep = "Failed to put coffee in machine";
            }

        }

        private void PutWaterInMachine()
        {
            Console.WriteLine("Attempting to put water in machine...");
            Thread.Sleep(1000);

            if (DetermineSuccess())
            {
                // Lyckas
                Console.WriteLine("Putting water in machine successfull!");
                PutCupInMachine();
            }
            else
            {
                // Misslyckas
                newCoffee!.FailedStep = "Failed to put water in machine";
            }
        }

        public void PutCupInMachine()
        {
            Console.WriteLine("Attempting to put cup in machine...");
            Thread.Sleep(1000);

            if (DetermineSuccess())
            {
                // Lyckas
                Console.WriteLine("Putting coffee in cup successfull!");
                StartMachine();
            }
            else
            {
                // Misslyckas
                newCoffee!.FailedStep = "Failed to put cup in machine";
            }
        }

        public void StartMachine()
        {
            Console.WriteLine("Attempting to start machine...");
            Thread.Sleep(1000);

            if (DetermineSuccess())
            {
                // Lyckas
                Console.WriteLine("Starting machine successfull!");
                ServeCoffeeToGuest();
            }
            else
            {
                // Misslyckas
                newCoffee!.FailedStep = "Failed to start machine";
            }
        }

        private void ServeCoffeeToGuest()
        {
            Console.WriteLine("Attempting to serve coffee to guest...");
            Thread.Sleep(1000);

            if (DetermineSuccess())
            {
                // Lyckas
                Console.WriteLine("You have successfully served the guest with coffee!");
                newCoffee!.IsDone = true;

            }
            else
            {
                // Misslyckas
                newCoffee!.FailedStep = "Failed to serve guest with coffee...";
            }
        }


    }
}
