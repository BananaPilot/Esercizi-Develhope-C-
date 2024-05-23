Console.WriteLine("Give me a temperature");
var temp = Console.ReadLine();
Console.WriteLine("In which format you want to convert?");
var format = Console.ReadLine();
if (format.ToLower().Equals("celsius"))
{
    Console.WriteLine(ToCelsius(double.Parse(temp)));
    return;
}
Console.WriteLine(ToFahrenheit(double.Parse(temp)));


double ToFahrenheit(double input)
{
    return (input * 1.8) / 32;
}

double ToCelsius(double input)
{
    return (input - 32) * 0.5556;
}


