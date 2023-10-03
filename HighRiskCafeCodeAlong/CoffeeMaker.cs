namespace HighRiskCafeCodeAlong
{
    internal class CoffeeMaker
    {

        private List<string> _coffeeTypes = new() { "Espresso", "Macchiato", "Cortado", "Mocha", "Americano", "Cappuccino" };

        public void MakeCoffee()
        {
            string? response = AskForCoffee();
        }

        private string? AskForCoffee()
        {
            bool isAskingForCoffee = true;

            while (isAskingForCoffee)
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

            return null;
        }

        private void AskForCoffeeType()
        {

        }

        private void ValidateCoffeeType()
        {

        }

        private void CalculateSuccess()
        {

        }

        private void PutCoffeeInMachine()
        {

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
