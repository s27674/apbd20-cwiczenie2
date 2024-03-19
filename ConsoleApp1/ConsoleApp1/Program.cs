using ConsoleApp1.Containers;

var container = new Container(12.0)
{
    CargoWieght = 10.0
    
};
Console.WriteLine(container.CargoWieght);
Container contianer = new LiquidContainer(10.0);

//ArrayList
List<int> nums = new List<int>() {1, 2, 3};
List<int> nums2 = new() {1, 2, 3};
//HashMap
Dictionary<PossibleProducts, double> products = new();