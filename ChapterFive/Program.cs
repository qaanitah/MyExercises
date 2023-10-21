

static void TwoIntegersGreaterThanAndLessThan()
{
    // Write an if-statement that takes two integer variables and exchanges
    // their values if the first one is greater than the second one.

    Console.WriteLine("$$$$$$$$$$$$Question 1$$$$$$$$$$$$$$$");
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        Console.WriteLine("First number - {0}, Second number - {1}.", a, b);
}

static void FindBiggestOfThreeIntegers()
{
    // Write a program that finds the biggest of three integers, using nested 
    // if statements.

    Console.WriteLine("$$$$$$$$$$$$$Question 3$$$$$$$$$$$$");
    Console.WriteLine("Input first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third number: ");
            int z = int.Parse(Console.ReadLine());

            if(x > y)
               if (x > z) Console.WriteLine("X is the biggest");
               else if (x < z) Console.WriteLine("Z is the biggest");
               else Console.WriteLine("X and Z are the biggest");
            else if (x < y)
             if (y > z) Console.WriteLine("Y is the biggest");
               else if (x > z) Console.WriteLine("Z is the biggest");
               else Console.WriteLine("Y and Z are the biggest");
            else if (x == y)
            if (x == z) Console.WriteLine("All are equal");
            else if (x < z) Console.WriteLine("Z is the biggest");
            else Console.WriteLine("X and Y are the biggest"); 
}

static void SortRealNumbersInDescendingOrder()
{
   // Sort 3 real numbers in descending order. Use nested if statements.

    Console.WriteLine("$$$$$$$$$$$$$$$Question 4$$$$$$$$$$$$$$$$");
        Console.WriteLine("Input first number: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second number: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Input third number: ");
        int r = int.Parse(Console.ReadLine());
        if (p < q)
        {
            if (p < r)
            {
                p = p + r;
                r = p - r;
                p = p - r;
                if (q > r)
                {
                    p = p + q;
                    q = p - q;
                    p = p - q;
                }
            }
            else if (p >= r)
            {
                p = p + q;
                q = p - q;
                p = p - q;
            }
        }
        else if ( p == q)
        {
            if ( p < r)
            {
                p = p + r;
                r = p - r;
                p = p - r;
            }
        } 
        else
        {
                if (q < r)
            {
                q = q + r;
                r = q - r;
                q = q - r;
            }
            if (p < q)
                {
                p = p + q;
                q = p - q;
                p = p - q;
            }
        }
        Console.WriteLine("{0}, {1}, {2}", p, q, r);
        Console.ReadLine();
}

static void CoefficientOfAQuadraticEquation()
{
    //     Write a program that gets the coefficients a, b and c of a quadratic 
    // equation: ax
    // 2 + bx + c, calculates and prints its real roots (if they exist). 
    // Quadratic equations may have 0, 1 or 2 real  roots.

    Console.WriteLine("$$$$$$$$$$$$$$Question 6$$$$$$$$$$$$$");
        Console.WriteLine("Enter J (not 0): ");
        int j = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter L: ");
        int l = int.Parse(Console.ReadLine());

        int m = (int)(k * k - 4 * j * l);
        if (m < 0)
            Console.WriteLine("\nM={0}\nThere no real roots.", m);
        else if (m == 0)
        {
            int x1 = (int)(-k / 2 * j);
            Console.WriteLine("\nX={0}", x1);
        } 
            else
        {
            int x1 = (int)((-k + Math.Sqrt(m)) / (2 * j));
            int x2 = (int)((-k - Math.Sqrt(m)) / (2 * j));
            Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
        }   
        Console.ReadLine(); 
}

static void PrintsGreatestOfFiveNumbers();
{

    //Write a program that finds the greatest of given 5 numbers.

    Console.WriteLine("$$$$$$$$$$$$$Question 7$$$$$$$$$$$$$$$$");
        Console.WriteLine("Enter first number: ");
        int firstNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int thirdNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number: ");
        int fourthNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number: ");
        int fifthNo = int.Parse(Console.ReadLine());
        if((firstNo > secondNo && firstNo > thirdNo && firstNo > fourthNo && firstNo > fifthNo ))
        {
            Console.WriteLine($"The greatest number : {firstNo}");
        }
        if((secondNo > firstNo && secondNo > thirdNo && secondNo > fourthNo && secondNo > fifthNo))
        {
            Console.WriteLine($"The greatest number : {secondNo}");
        }
        if((thirdNo > firstNo && thirdNo > secondNo && thirdNo > fourthNo && thirdNo > fifthNo))
        {
            Console.WriteLine($"The greatest number : {thirdNo}");
        }
        if((fourthNo > firstNo && fourthNo > secondNo && fourthNo > thirdNo && fourthNo > fifthNo))
        {
            Console.WriteLine($"The greatest number : {fourthNo}");
        }
        if((fifthNo > firstNo && fifthNo > secondNo && fifthNo > thirdNo && fifthNo > fourthNo ))
        {
            Console.WriteLine($"The greatest number : {fifthNo}");
        }
}

static void bonusPoints()
{
    //     Write a program that applies bonus points to given scores in the range 
    // [1…9] by the following rules:
    // - If the score is between 1 and 3, the program multiplies it by 10.
    // - If the score is between 4 and 6, the program multiplies it by 100.
    // - If the score is between 7 and 9, the program multiplies it by 1000.
    // - If the score is 0 or more than 9, the program prints an error 
    // message.

    Console.WriteLine("$$$$$$$$$$$$Question 10$$$$$$$$$$$$$$");
        int points;
        Console.WriteLine("Enter points between 1 and 9: ");
        points = int.Parse(Console.ReadLine());
        if (points >= 1 && points <= 3)
            Console.WriteLine("Points multiplied by 10: {0}", points * 10);
        else if (points >= 4 && points <= 6)
            Console.WriteLine("Points multiplied by 100:", points * 100);
        else if (points >= 7 && points <= 9)
            Console.WriteLine("Points multiplied by 1000:", points * 1000);
        else
            Console.WriteLine("Wrong Input!");
        Console.ReadLine();  
}

