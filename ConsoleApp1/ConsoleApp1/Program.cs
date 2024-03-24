using ConsoleApp1.Containers;
using ConsoleApp1.Exceptions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Liquid
                LiquidContainer lcontainer1 = new LiquidContainer(5000, 1000, 300, 300, "Petrol");
                LiquidContainer lcontainer2 = new LiquidContainer(5000, 1000, 200, 300, "Milk");
                lcontainer1.LoadCargo(2000);
                lcontainer2.LoadCargo(4000);
                lcontainer1.UnloadCargo();
                lcontainer2.UnloadCargo();
                
                
                //Gas
                GasContainer gContainer1 = new GasContainer(5000, 1000, 200, 300, 5);
                GasContainer gContainer2 = new GasContainer(5000, 1000, 200, 300, 3);
                gContainer1.LoadCargo(3000);
                gContainer2.LoadCargo(2000);
                gContainer1.UnloadCargo();
                gContainer2.UnloadCargo();
                
                
                //Refrigerated
                RefrigeratedContainer rcontainer1 = new RefrigeratedContainer(5000, 1000, 200, 300, 13.2, PossibleProducts.Bananas);
                RefrigeratedContainer rcontainer2 = new RefrigeratedContainer(5000, 1000, 200, 300, 3, PossibleProducts.Fish);
                rcontainer1.LoadCargo(2000);
                rcontainer2.LoadCargo(2000);
                
                //ContainerShip
                ContainerShip cs = new ContainerShip(100, 50, 100000);
                cs.AddContainer(lcontainer1);
                cs.AddContainer(lcontainer2);
                cs.AddContainer(gContainer1);
                cs.AddContainer(gContainer2);
                cs.AddContainer(rcontainer1);
                cs.AddContainer(rcontainer2);
                
                
                
                //serialnumber
                Console.WriteLine(lcontainer1.SerialNumber);
                Console.WriteLine(lcontainer2.SerialNumber);
                
            }
            catch (OverfillException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (TemperatureException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}