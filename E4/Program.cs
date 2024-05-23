Console.WriteLine("Write a word");
var word = Console.ReadLine();
char[] splitWord = word.ToCharArray();
Array.Reverse(splitWord);
string stringToReturn = new string(splitWord);
Console.WriteLine(stringToReturn);