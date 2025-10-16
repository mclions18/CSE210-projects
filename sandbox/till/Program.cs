namespace Till;

class Program
{
    static void Main(string[] args)
    {
        Bin myBin = new Bin("Twenties", 20.00, 5);
        Bin newBin = new Bin("Tens", 10.00, 10);
        Bin pennyBin = new Bin("Penny", 0.01, 50);

        pennyBin.Alter(11);
        Console.WriteLine($"{pennyBin.GetDenomination()}");
        Console.WriteLine($"{pennyBin.GetCount()}");
    }
}