namespace HighRiskCafeCodeAlong
{
    internal class Coffee
    {
        public bool IsDone { get; set; }

        public string CoffeeType { get; set; }

        public string FailedStep { get; set; } = "";

        public Coffee(string coffeeType)
        {
            CoffeeType = coffeeType;
        }
    }
}
