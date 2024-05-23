Console.WriteLine("Path of the file to read");
var path = Console.ReadLine();
if (!File.Exists(path))
{
     Console.WriteLine("File does not exist");
     return;
}
Console.WriteLine(File.ReadAllText(path));
