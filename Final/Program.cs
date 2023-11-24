
string[] Symbols(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    string[] input_symbols = new string [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";
        
        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        input_symbols[index] = temp;
        index++;
    }
    return input_symbols;
}


string OriginalArray(string[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}, " : $"{array[i]}]";
    }
    return output;
}

string NewArray(string[] array)
{
    Random random = new Random(); 

    int max_i_newArray = random.Next(4); 
    HashSet<int> setOfIndexes = new HashSet<int>();
    
    string output = "[";
    for (int i = 0; i < max_i_newArray;)
    {
        int i_oldArray = random.Next(array.Length); 

        if (setOfIndexes.Add(i_oldArray))
        {
            output += (i < max_i_newArray - 1) ? $"{array[i_oldArray]}, " : $"{array[i_oldArray]}";
            i++;
        }
    }
    output += "]";
    return output;
}


Console.Write("Enter 3 or more symbols separated by commas: ");
string[] symbols = Symbols(Console.ReadLine());
Console.WriteLine($"{OriginalArray(symbols)} -> {NewArray(symbols)}");
