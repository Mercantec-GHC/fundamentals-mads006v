for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i+" bankebøf");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " banke");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " bøf");
    }
    else
    {
        Console.WriteLine(i);
    }
}