string[] a1 = new string[6] { "Goodbye", "to", "050", "тон", "sons", "love" };
string[] a2 = new string[a1.Length];
void ArrayCycle(string[] a1, string[] a2)
{
    int k = 0;
    for (int i = 0; i < a1.Length; i++)
    {
        if (a1[i].Length <= 3)
        {
            a2[k] = a1[i];
            k++;
        }
    }
}
void PrintArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine();
}
ArrayCycle(a1, a2);
PrintArray(a2);