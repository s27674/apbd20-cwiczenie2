using ConsoleApp1.Exceptions;

namespace ConsoleApp1.Containers;

public class RefrigeratedContainer : Container
{
    public double CurrentTemperature { get; set; }
    public double ProductTemperature { get; set; }
    public PossibleProducts Product { get; set; }
    
    public RefrigeratedContainer(double maxCargoWeight, double emptyWeight, double height, double depth, double currentTemperature, PossibleProducts product) : 
        base(maxCargoWeight, emptyWeight, height, depth)
    {
        Product = product;
        CurrentTemperature = currentTemperature;
        Type = "C";
        GenerateSerialNumber();
    }
    
    public void LoadCargo(double weight)
    {
        if (weight > MaxCargoWeight)
        {
            throw new OverfillException("The permissible load capacity of the container has been exceeded!");
        }
        
        if (CurrentTemperature < (int)Product/10)
        {
            throw new TemperatureException("The temperature in the container is below the required temperature!");
        }

        base.LoadCargo(weight);
    }
    
    
    
}