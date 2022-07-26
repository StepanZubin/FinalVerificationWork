// array of strings
string[] arrayInput = new string[4] {"hello", "2", "world", ":-)"};
int size = 0;
string[] arrayOutput = new string[size];
int indexInput = 0;
int indexOutput = 0; 
   

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