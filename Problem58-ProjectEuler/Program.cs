string[] allPrimes = File.ReadAllText(@"C:\Users\nikil\Documents\Developer\Excercises\First5MPrimes\allPrimes.txt").Split(",");

double totalPrimes = 0;
double totalNoPrimes = 1;
double counter = 1;
double jumpSize = 2;
double numberOfJumps = 1;
double startValue = 1;

while (true)
{
    counter++;
    if(counter == startValue + jumpSize * numberOfJumps)
    {
        if (allPrimes.Contains(counter.ToString()))
            totalPrimes++;
        else
            totalNoPrimes++;
        if(numberOfJumps < 4)
            numberOfJumps++;
        else
        {
            if (totalPrimes / (totalPrimes + totalNoPrimes) < 0.1)
                break;
            numberOfJumps = 1;
            jumpSize += 2;
            startValue = counter;
        }

    }
}

Console.WriteLine(counter);
Console.WriteLine("The side length of the square spiral for which the ratio of primes along both diagonals first falls below 10% is: " + (jumpSize + 1));


