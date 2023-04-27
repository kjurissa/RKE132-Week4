int sum = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i + 1}");
    Console.WriteLine($"Summa: {sum}");
    sum = sum + i;
}

//for (int a = 10; a > 0; a--)
//{
//    Console.WriteLine($"i = {a - 1}");
//}

Console.WriteLine($"Viimane summa {sum}");