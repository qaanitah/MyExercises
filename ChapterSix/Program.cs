// Write a program that prints on the console the numbers from 1 to N. 
// The number N should be read from the standard input.

Console.WriteLine("Enter a number (N):");
int length = int.Parse(Console.ReadLine());
PrintNumberUpToN(n);

static void PrintNumberUpToN(int n)
{
    
    Console.WriteLine("<<<<<<<<<<<<<<<<Question 1>>>>>>>>>>>>>>>>>>");
        for(int i = 1; i < length; i++)
        {
            Console.WriteLine(i);
        }
}

static void NotDivisibleBy3And7()
{
    //Write a program that prints on the console the numbers from 1 to N, 
    //which are not divisible by 3 and 7 simultaneously. The number N 
    //should be read from the standard input.

    Console.WriteLine("<<<<<<<<<<<<<<<<<<Question 2>>>>>>>>>>>>>>>>");
        Console.WriteLine("Enter N: ");
        int length = int.Parse(Console.ReadLine());

        for (int i = 1; i < length; i++)
        {
            if (i % (3 * 7) != 0) Console.WriteLine(i);
        } 
}

static void PrintSmallestAndLargest()
{
    // Write a program that reads from the console a series of integers and 
    // prints the smallest and largest of them.

    Console.WriteLine("<<<<<<<<<<<<<<Question 3>>>>>>>>>>>>>>>");
        int smallest = 0;
        int largest = 0;
        int input;
        Console.WriteLine("Enter the length of numbers: ");
        int length = int.Parse(Console.ReadLine());

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (i == 0) smallest = largest = input;
            else
            {
                if (smallest > input) smallest = input;
                if (largest < input) largest = input;
            }
        } 
        Console.WriteLine("Smallest - {0}, Largest - {1}", smallest, largest);
}

static void CalculatesNAndK()
{
    //Write a program that calculates N!/K! for given N and K (1<K<N).

    Console.WriteLine("<<<<<<<<<<<<<<<<Question 6>>>>>>>>>>>>>");
        Console.WriteLine("Enter N: (1<K<N) ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: (1<K<N) ");
        int k = int.Parse(Console.ReadLine());

        for (int i = n - 1; i > 0; i--)
        {
            n *= i;
        } 
        for (int i = k - 1; i > 0; i--)
        {
            k *= i;
        }
        n /= k;
        Console.WriteLine("Result is {0}", n);
}

static void PrintsAMatrixOfNumbers()
{
    //     Write a program that reads from the console a positive integer number 
    // N (N < 20) and prints a matrix of numbers as on the figures below:
    // N = 3 N = 4
    // 1 2 3
    // 2 3 4
    // 3 4 5
    // 1 2 3 4
    // 2 3 4 5
    // 3 4 5 6
    // 4 5 6 7

    Console.WriteLine("<<<<<<<<<<<<<<<Question 10>>>>>>>>>>>>>>>>");
        Console.WriteLine("Enter N: (N < 20) ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= i; j++)
            {
                Console.WriteLine("{0}", j);
            }
            Console.ReadLine();
        }
}

static void ConvertFromDecimalToBinary()
{
    // Write a program that converts a given number from decimal to binary 
    // notation (numeral system).

    Console.WriteLine("<<<<<<<<<<<<<<Question 12>>>>>>>>>>>>>>>>>");
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        Console.WriteLine("Result is {0}", binary);
}

static void ConvertFromBinaryToDecimal()
{
    // Write a program that converts a given number from binary to decimal 
    // notation.

    Console.WriteLine("<<<<<<<<<<<<<<<<Question 13>>>>>>>>>>>>>");
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        string decimal = Convert.ToString(n, 10);
        Console.WriteLine("Result is{0}",decimal);
}

