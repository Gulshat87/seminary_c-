Console.Clear();

string Number(int a, int b)
{
    if (a <= b) 
    {
        return $"{a} " + Number(a + 1,b);
    }
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(Number(1,10));

