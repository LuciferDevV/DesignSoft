struct Prices
{
    public int Drink;
    public int First;
    public int Second;
}

struct Choices
{
    public int Drink;
    public int First;
    public int Second;
}

class Program
{
    static int CustomerTotal(Prices prices, Choices choices)
    {
        return choices.Drink * prices.Drink +
               choices.First * prices.First +
               choices.Second * prices.Second;
    }

    static void Main()
    {
        Prices prices;
        prices.Drink = 10;
        prices.First = 20;
        prices.Second = 30;

        {
            Choices client1;
            client1.Drink = 3;
            client1.First = 5;
            client1.Second = 0;

            int total1 = CustomerTotal(prices, client1);
            System.Console.WriteLine("Клиент 1: " + total1);
        }

        {
            Choices client2;
            client2.Drink = 4;
            client2.First = 2;
            client2.Second = 5;

            int total2 = CustomerTotal(prices, client2);
            System.Console.WriteLine("Клиент 2: " + total2);
        }
    }
}
