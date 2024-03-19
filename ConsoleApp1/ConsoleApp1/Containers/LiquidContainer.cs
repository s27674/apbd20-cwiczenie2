using System.Transactions;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWieght) : base(cargoWieght)
    {
        
    }
    
    public override void Load(double cargoWeight)
    {
      Console.WriteLine("LiquidContainer");
    }
}