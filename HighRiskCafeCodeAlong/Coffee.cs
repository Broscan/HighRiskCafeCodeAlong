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

        public string GetInfo()
        {
            if (IsDone)
            {
                return $"{CoffeeType} was made successfully";
            }
            else
            {
                return $"Failed to make {CoffeeType}. {FailedStep}";
            }
        }
    }
}
