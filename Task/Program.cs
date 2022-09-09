
string[] input = { "hello", "2", "world", ":-)" };
string[] output = new string[input.Length];

Main(input, output);

//решение задачи
void Main(string[] input, string[] output)
{
    int a = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != null && input[i].Length <= 3)
        {
            output[a] = input[i];
            a++;
        }
    }
    PrintOneDimArray(output);
}

//метод для печати одномерного массива
void PrintOneDimArray(string[] output)
{
    int i = 0;
    while (i < output.Length)
    {
        if (output[i] != null)
        {
            Console.Write(output[i] + " ");
        }
        i++;
    }
}
