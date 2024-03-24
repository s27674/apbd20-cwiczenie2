using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;
namespace ConsoleApp1.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public string _liquid { get; set; }

    public LiquidContainer(double maxCargoWeight, double emptyWeight, double height, double depth, string liquid) 
        : base(maxCargoWeight,emptyWeight,height,depth)
    {
        _liquid = liquid;
        Type = "L";
        GenerateSerialNumber();
    }
    public void NotifyHazard(string containerSerialNumber)
    {
        Console.WriteLine($"Danger! Container {{containerSerialNumber}} is carrying dangerous goods!");
    }
    public void LoadCargo(double weight)
    {
        if (IsHazardousCargo())
        {
            NotifyHazard(SerialNumber);
            if (weight + CargoWeight > MaxCargoWeight * 0.5)
            {
                throw new OverfillException("Do not load more than 50 % of the dangerous goods capacity!");
            }
        }
        else
        {
            if (weight + CargoWeight > MaxCargoWeight * 0.9)
            {
                throw new OverfillException("It is not possible to load more than 90% of the capacity!");
            }
        }

        base.LoadCargo(weight);
        
    }
    private bool IsHazardousCargo()
    {
        if (_liquid == "Petrol")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}