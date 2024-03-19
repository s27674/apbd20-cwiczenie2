using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class Container : IContainer
{
    public double CargoWieght { get; set; }

    public Container(double cargoWieght)
    {
        CargoWieght = cargoWieght;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        CargoWieght = cargoWeight;
        //throw new OverfillException();
    }
}
