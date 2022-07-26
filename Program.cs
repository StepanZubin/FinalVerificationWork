// array of strings
string[] arrayInput = new string[4] {"hello", "2", "world", ":-)"};
string[] arrayOutput = new string[arrayInput.Length];
int indexInput = 0;
int indexOutput = 0; 


PrintStringArray(arrayInput);

void PrintStringArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}