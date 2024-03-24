namespace ConsoleApp1.Exceptions;

public class TemperatureException : Exception
{
    public TemperatureException(string? message) : base(message)
    {
    }
}