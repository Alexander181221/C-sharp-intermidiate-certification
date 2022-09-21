Console.WriteLine("Задайте число строк");
int count = Convert.ToInt32(Console.ReadLine());
string [] array = new string [count];

string [] GreaterOrLesserValue (string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
        
    }
 
 string [] result = new string[count];
 int j = 0;

 for (int i = 0; i < array.Length; i++)
 {
    if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
 }

}

