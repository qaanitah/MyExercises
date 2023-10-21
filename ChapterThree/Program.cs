
static void EvenOrOdd()
{
    // Write an expression that checks whether an integer is odd or even
    
    Console.WriteLine("******************Question 1******************");
        Console.WriteLine("Enter any number: ");
        int number = int.Parse(Console.ReadLine());
    
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even."); 
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
}

static void DivisibleByFiveAndSevenWithoutRemainder()
{
    // Write a Boolean expression that checks whether a given integer is 
    // divisible by both  5 and 7, without a remainder
    
    Console.WriteLine("*****************Question 2*********************");
        int n = int.Parse(Console.ReadLine());
        if (n % 5 == 0 && n % 7 ==0)
        {
            Console.WriteLine("{0} is divisible by both 5 and 7 without any remainder", n);
        }
        else
        {
            Console.WriteLine("{0} is not divisible by both 5 and 7 without any remainder", n);
        }
}

static void ThirdDigit()
{
    // Write an expression that looks for a given integer if its third digit (right 
    // to left) is 7.
    
    
    Console.WriteLine("*****************Question 3********************");
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int thirdD = (number / 100) % 10;
        if (thirdD == 7)
        {
            Console.WriteLine("The third digit is seven! ");
        }
        else
        {
            Console.WriteLine("The third digit is not seven. ");
        }
}

static void ChecksTheThirdBitOfAnIntegerIsEitherOneOrZero()
{
    // Write an expression that checks whether the third bit in a given integer 
    // is 1 or 0.
    
    Console.WriteLine("*********************Question 4******************");
        Console.WriteLine("Enter an integer = ");
        int integer = int.Parse(Console.ReadLine());
        bool bit3 = (integer & 8) != 0;
        Console.WriteLine(bit3);
        Console.WriteLine();
}

static void CalculatesTheAreaOfATrapezoid()
{
    // Write an expression that calculates the area of a trapezoid by given 
    // sides a, b and height h.
    
    Console.WriteLine("***************Question 5********************");
        Console.WriteLine("Enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area of trapezoid is {0}" , area);
}

static void PrintsPerimeterAndAreaOfARectangle()
{
    // Write a program that prints on the console the perimeter and the area 
    // of a rectangle by given side and height entered by the user.
    
    Console.WriteLine("******************Question 6****************");
        Console.WriteLine("Enter p: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter q: ");
        int q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("S = {0}, P = {1}", p * q, (p + q) * 2);
}

static void CalculatesTheWeightOfAMan()
{
    // The gravitational field of the Moon is approximately 17% of that on the 
    // Earth. Write a program that calculates the weight of a man on the 
    // moon by a given weight on the Earth.
    
    Console.WriteLine("*****************Question 7*****************");
        Console.WriteLine("Enter the weight: ");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("The weight on the Moon is: {1} kg.", weightOnEarth,weightOnMoon);
}

static void ChecksForAGivenPoint()
{
    // Write an expression that checks for a given point {x, y} if it is within 
    // the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
    // the circle and 5 is the radius.
    
    Console.WriteLine("*******************Question 8*****************");
        Console.WriteLine("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double d1 = (x * x) + (y * y);
        double d2 = Math.Sqrt(d1);
        
        int a1 = -1;
        int a2 = 5;
        int b1 = 1;
        int b2 = 5;
        double d3 = (a2-a1) * (a2-a1) - (b2-b1) * (b2-b1);
        double d4 = Math.Sqrt(d3);
    
        if(d2 <= 5 && d4 <= 5)
        {
            Console.WriteLine("It is within the circle and out of the rectangle");
        }
        else
        {
            Console.WriteLine("It is outside the circle and within the rectangle");
        }
}

static void InputOfAFourDigitNumber()
{
    // Write a program that takes as input a four-digit number in format abcd
    // (e.g. 2011) and performs the following actions:
    // - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    // - Prints on the console the number in reversed order: dcba (in our 
    // example 1102).
    // - Puts the last digit in the first position: dabc (in our example 1201).
    // - Exchanges the second and the third digits: acbd (in our example 
    // 2101)
    
    Console.WriteLine("*****************Question 10******************");
        int n = int.Parse(Console.ReadLine());
        int numOne = (n / 1000) % 10;
        int numTwo = (n / 100) % 10;
        int numThree = (n / 10) % 10;
        int numFour = (n % 10);
    
        Console.WriteLine("The sum of the digits is: {0}", numOne + numTwo + numThree + numFour);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}", numFour, numThree, numTwo, numOne);
        Console.WriteLine("Last digit at the front: {0}{1}{2}{3}", numFour, numOne, numTwo, numThree);
        Console.WriteLine("Exchanges the second and third digits: {0}{1}{2}{3}{4}",numOne, numThree, numTwo, numFour);
}
