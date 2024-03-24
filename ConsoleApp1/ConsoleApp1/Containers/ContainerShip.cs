namespace ConsoleApp1.Containers;

public class ContainerShip
{
    private List<Container> Containers = new List<Container>();
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }
    public double Weight { get; set; }

    public ContainerShip(double maxSpeed, int maxContainers, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void AddContainer(Container container)
    {
        if (Containers.Count < MaxContainers)
        {
            Containers.Add(container);
            Weight += container.CargoWeight;
            Weight += container.EmptyWeight;
            Console.WriteLine(
                $"Container {container.SerialNumber} has been added! Number of remaining seats {Containers.Count}/{MaxContainers}. Weight container ship: {Weight}");
        }
        else
        {
            throw new InvalidOperationException("Maximum number of containers reached.");
        }
        
    }
    
}