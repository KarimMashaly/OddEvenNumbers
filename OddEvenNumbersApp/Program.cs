

    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    PrintNumbers("Numbers", numbers);
    PrintNumbers("Even No", numbers.Where(n => IsEven(n)));
    PrintNumbers("Odd No", numbers.Where(n => !IsEven(n)));

void PrintNumbers(string title, IEnumerable<int>numbers)
{
    Console.WriteLine();
    Console.WriteLine($"{title}: [");
    foreach( int number in numbers )
    {
        Console.Write( $" {number}" );
    }
    Console.WriteLine($" ]");
    Console.WriteLine();
}
bool IsEven(int number)
{
    if (number % 2 == 0)
        return true;
    else
        return false;
}