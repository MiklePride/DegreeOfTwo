class program
{
    static void Main(string[] args)
    {
        int minimumRandomNumbers = 10;
        int maximumRandomNumbers = 30;
        int numberRaisedToPower = 2;
        Random random = new Random();
        int randomNumbers = random.Next(minimumRandomNumbers, maximumRandomNumbers);
        int power = 1;
        int resultOfExponentiation = 2;

        for (int i = power; power < randomNumbers; power++)
        {
            if (resultOfExponentiation <= randomNumbers)
            {
                resultOfExponentiation = numberRaisedToPower * resultOfExponentiation;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"Минимальная степень двойки, превосходящая число {randomNumbers} будет {numberRaisedToPower}^{power}. {randomNumbers}<{resultOfExponentiation}");
    }
}