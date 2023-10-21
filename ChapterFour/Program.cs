

static void PrintsSumOfThreeNumbers()
{
    // Write a program that reads from the console three numbers of type int
    // and prints their sum.
    
    Console.WriteLine("###################Question 1####################");
        Console.WriteLine("First number: ");
        int firstNu = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Second number: ");
        int secondNu = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Third number: ");
        int thirdNu = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Sum is {0}", firstNu + secondNu + thirdNu);
}

static void PrintsRadiusOfACircle()
{
    // Write a program that reads from the console the radius "r" of a circle 
    // and prints its perimeter and area.
    
    Console.WriteLine("#################Question 2#####################");
        Console.WriteLine("Enter r: ");
        double r = double.Parse(Console.ReadLine());
        double area = (Math.PI * r * r );
        double perimeter = (2 * Math.PI * r);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
}

static void InformationOfAComPany()
{
    //A given company has name, address, phone number, fax number, web 
    // site and manager. The manager has name, surname and phone number.
    // Write a program that reads information about the company and its 
    // manager and then prints it on the console.
    
    Console.WriteLine("#################Question 3#######################");
        Console.WriteLine("Enter the company's name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter the company's address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter your phone number: ");
        long phoneNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter your fax number: ");
        long faxNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company's website: ");
        string website = Console.ReadLine();
        Console.WriteLine("Enter the manager's first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the manager's last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the manager's age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the manager's phone number: ");
        long managerPhoneNumber = long.Parse(Console.ReadLine());


        Console.WriteLine("Name:{0}", companyName);
        Console.WriteLine("Address:{0}", companyAddress);
        Console.WriteLine("Phonenumber: {0}", phoneNumber);
        Console.WriteLine("Faxnumber: {0}", faxNumber);
        Console.WriteLine("Web-site: {0}", website);
        Console.WriteLine("Manager: {0}" + " " + "{1}" + " " + "age: {2}," + " " + "Phonenumber: {3}", firstName, lastName, age, managerPhoneNumber);
}

static void PrintsThreeNumbersInThreeVirtualColumns()
{
    // Write a program that prints three numbers in three virtual columns
    // on the console. Each column should have a width of 10 characters and 
    // the numbers should be left aligned. The first number should be an 
    // integer in hexadecimal; the second should be fractional positive; and 
    // the third – a negative fraction. The last two numbers have to be 
    // rounded to the second decimal place.
    
    Console.WriteLine("################Question 4######################");
        int hexNum = 432;
        double fractNo = 234.6769;
        double negativeFractNo = -234.6769;
        Console.WriteLine("|{0, -10:x}|", hexNum);
        Console.WriteLine("|{0, -10:f}|", fractNo);
        Console.WriteLine("|{0, -10:f}|", negativeFractNo);
}

static void TwoIntegers()
{
    // Write a program that reads from the console two integer numbers (int)
    // and prints how many numbers between them exist, such that the 
    // remainder of their division by 5 is 0. Example: in the range (14, 25) 
    // there are 3 such numbers: 15, 20 and 25.
    
    Console.WriteLine("#################Question 5#################");
        int counter = 0;
                
        Console.WriteLine("Enter first number: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = Int32.Parse(Console.ReadLine());
    
        for(int i = a; i <= b; i++)
        {
            if (i % 5 == 0) counter++;
        }
        Console.WriteLine("{0} Numbers found.", counter);
}

static void ReadsTwoNumbers()
{
    // Write a program that reads two numbers from the console and prints the 
    // greater of them. Solve the problem without using conditional 
    // statements.
    
    Console.WriteLine("##################Question 6#################");
        Console.WriteLine("Input the First number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Input the Second number: ");
        double num2 = double.Parse(Console.ReadLine());
    
        double greaterNumber = Math.Max(num1, num2);
        Console.WriteLine("Number {0} is greater", greaterNumber);
}

static void PrintsSumOfFiveIntegers()
{
    // Write a program that reads five integer numbers and prints their 
    // sum. If an invalid number is entered the program should prompt the user 
    // to enter another number.
    
    Console.WriteLine("#############Question 7################");
        Console.WriteLine("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Third number: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Fourth number: ");
        int num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Fifth number: ");
        int num5 = int.Parse(Console.ReadLine());
    
        Console.WriteLine("Sum is {0}", num1 + num2 + num3 + num4 + num5 );
}

static void PrintsGreatestOfFiveNumbers()
{
    // Write a program that reads five numbers from the console and prints the 
    // greatest of them.
    
    Console.WriteLine("###################Question 8################");
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
        if((firstNo > secondNo && firstNo > thirdNo && firstNo > fourthNo && firstNo > fifthNo))
        {
            Console.WriteLine($"The greatest number: {firstNo}");
        }
        if((secondNo > firstNo && secondNo > thirdNo && secondNo > fourthNo && secondNo > fifthNo))
        {
            Console.WriteLine($"The greatest number: {secondNo}");
        }
        if((thirdNo > firstNo && thirdNo > secondNo && thirdNo > fourthNo && thirdNo > fifthNo))
        {
            Console.WriteLine($"The greatest number: {thirdNo}");
        };
        if((fourthNo > firstNo && fourthNo > secondNo && fourthNo > thirdNo && fourthNo > fifthNo))
        {
            Console.WriteLine($"The greatest number: {fourthNo}");
        }
        if((fifthNo > firstNo && fifthNo > secondNo && fifthNo > thirdNo && fifthNo > fourthNo))
        {
            Console.WriteLine($"The greatest number: {fifthNo}");
        }
}

static void ReadAndPrint()
{
    // Write a program that reads an integer number n from the console. After 
    // that reads n numbers from the console and prints their sum.
    
    Console.WriteLine("################Question 9#################");
        int sum = 0;
        Console.WriteLine("Enter numbers: ");
        int length = int.Parse(Console.ReadLine());
        for(int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter {0} number: ", i + 1);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum of all numbers is {0}. ", sum);
}

static void PrintsAllNumbers()
{
    // Write a program that reads an integer number n from the console and 
    // prints all numbers in the range [1…n], each on a sepparate line.
    
    Console.WriteLine("##################Question 10################");
        Console.WriteLine("Input numbers: ");
        int range = int.Parse(Console.ReadLine());
        for (int i = 1; i <= range; i++)
        {
            Console.WriteLine(i);
        }
}

static void FibonacciSequence()
{
    // Write a program that prints on the console the first 100 numbers in the 
    // Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
    
    Console.WriteLine("###############Question 11##############");
        int num1 = 0;
        int num2 = 1;
        int sum = 1;
        int count = 0;
    
        Console.WriteLine(num1);
        while(count < 100)
        {
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            Console.WriteLine(num2);
                count ++;
        }
}

static void Calculates()
{
    // Write a program that calculates the sum (with precision of 0.001) of 
    // the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
    
    Console.WriteLine("#################Question 12#################");
        Console.Write("Enter Length : ");
        double length = double.Parse(Console.ReadLine());
        double summingUp = 1.0d;
        for(int i = 2; i <= length; i++)
        {
            if(i % 2 == 0)
            {
                summingUp += (1.0 / i);
            }
            else if(i % 2 != 0)
            {
                summingUp += ( 1.0 / -i);
            }
        }
        double roundUpTo3DecimalPlaces = (double) Math.Round(summingUp, 3);
        Console.WriteLine(roundUpTo3DecimalPlaces);
        Console.WriteLine();
}   
