
//PrintAnyWord();
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); // userinput -argument


static void PrintAnyWord(string anystring) //anystring -parameter
{
    anystring= anystring.ToUpper();
   for(int i =0; i < 5; i++)
    {
        Console.WriteLine(anystring);
    }
}
  