using System.Security.Claims;
using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer
{
    public static int nextSerialNumber = 1;
    public string Type { get; set; }
    public string SerialNumber { get; set; }
    public double CargoWeight { get; set; }
    public double MaxCargoWeight { get; set; }
    public double EmptyWeight { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }

    public Container(double maxCargoWeight, double emptyWeight, double height, double depth)
    {
        MaxCargoWeight = maxCargoWeight;
        EmptyWeight = emptyWeight;
        Height = height;
        Depth = depth;
        CargoWeight = 0;
    }

    public void LoadCargo(double weight)
    {
        if (weight + CargoWeight > MaxCargoWeight)
        {
            throw new OverfillException("The permissible load capacity of the container has been exceeded!");
        }
        CargoWeight += weight;
        Console.WriteLine($"Container weight {SerialNumber}: {CargoWeight}");
    }

    public void UnloadCargo()
    {
        CargoWeight = 0;
        Console.WriteLine($"Container weight {SerialNumber}: {CargoWeight}");
    }

    public void GenerateSerialNumber()
    {
        SerialNumber = $"KON-{Type}-{nextSerialNumber}";
        nextSerialNumber++;
    }
}

