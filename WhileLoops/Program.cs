
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Arva number 1-3 vahemikus");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Võitsid");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Proovi uuesti");
    }
}
Console.WriteLine("Tubli oled!");