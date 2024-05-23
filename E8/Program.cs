Console.WriteLine("Write a word");
var input = Console.ReadLine().ToLower();
var inputToArray = input.ToCharArray();
Array.Reverse(inputToArray);
var reversed = new string(inputToArray);
if (reversed.Equals(input))
{
    Console.WriteLine("The inputted word is a palindrome");
    return;
}
Console.WriteLine("Word is not a palindrome");


