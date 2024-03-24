namespace ConsoleApp1.Interfaces;

public interface IContainer
{
    void UnloadCargo();
    void LoadCargo(double cargoWeight);
    public void GenerateSerialNumber();
}