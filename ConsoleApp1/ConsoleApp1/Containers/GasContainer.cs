using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double _pressure;
    public GasContainer(double maxCargoWeight, double emptyWeight, double height, double depth, double pressure) : 
        base(maxCargoWeight, emptyWeight, height, depth)
    {
        Type = "G";
        _pressure = pressure;
        GenerateSerialNumber();
    }
    public void NotifyHazard(string containerSerialNumber)
    {
        Console.WriteLine($"Incident! Container {{containerSerialNumber}} is overpressurised!");
    }
    public void LoadCargo(double weight)
    {
        if (weight > MaxCargoWeight)
        {
            throw new OverfillException("The permissible load capacity of the container has been exceeded!");
        }

        base.LoadCargo(weight);
    }
    public void UnloadCargo()
    {
        CargoWeight -= CargoWeight * 0.95;
        Console.WriteLine($"Container weight {SerialNumber}: {CargoWeight}");
    }
}