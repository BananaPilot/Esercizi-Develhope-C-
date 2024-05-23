Console.WriteLine("Give me a temperature in celsius");
var res = Console.ReadLine();
Console.WriteLine(ToFahrenheit(double.Parse(res)));


double ToFahrenheit(double input)
{
    return (input * 1.8) / 32;
}