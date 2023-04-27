Random rnd = new Random();

int myRandonNum;
int randomSum = 0;


for (int i = 0; i < 3; i++)
{
    myRandonNum = rnd.Next(0, 11); // 0 - 10 genereerib
    randomSum = randomSum + myRandonNum;
    Console.WriteLine($"Random number on:  {myRandonNum}");
}

Console.WriteLine($"Kõik {randomSum}");