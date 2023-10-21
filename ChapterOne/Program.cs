

static void VariablesDeclaration()
{
        // Declare several variables by selecting for each one of them the most 
        // appropriate of the types sbyte, byte, short, ushort, int, uint, long
        // and ulong in order to assign them the following values: 52,130; -115; 
        // 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
        // 1990; 123456789123456789

 Console.WriteLine("---------------Question 1--------------");
        ushort num1 = 52130;
        sbyte num2 = -115;
        uint num3 = 4825932;
        byte num4 = 97;
        short num5 = -10000;
        short num6 = 20000;
        byte num7 = 224;
        uint num8 = 970700000;
        sbyte num9 = 112;
        sbyte num10 = -44;
        int num11 = -1000000;
        ushort num12 = 1990;
        long num13 = 123456789123456789;

}

static void AssigningVariables()
{
        // Which of the following values can be assigned to variables of type float, 
        // double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
        // 3456.091124875956542151256683467?

        Console.WriteLine("=====================Question 2====================");
        double firstNum = 34.567839023;
        float secondNum = 12.345;
        double thirdNum = 8923.1234857;
        decimal fourthNum = 3456.091124875956542151256683467;
}

static void CompareRealNumbers()
{
        // Write a program, which compares correctly two real numbers with 
        // accuracy at least 0.000001

        Console.WriteLine("====================Question 3=====================");
        decimal firstNumber = 4.67543421794m;
        decimal secondNumber = 7.4326765838m;
        firstNumber += secondNumber;
        Console.WriteLine(firstNumber);
}

static void NumeralSystem()
{
       // Initialize a variable of type int with a value of 256 in
        // hexadecimal format (256 is 100 in a numeral system with base 16)

        Console.WriteLine("====================Question 4====================");
        int hexadecimalNumber = 0x100;
        Console.WriteLine("hexadecimalNumber");
 
}

static void GenderCheck()
{
       // Declare a variable isMale of type bool and assign a value to it depending 
        // on your gender.

        Console.WriteLine("====================Question 6=====================");
        bool isMale = false;
 
}

static void StringConcatenation()
{
        // Declare two variables of type string with values "Hello" and "World". 
        // Declare a variable of type object. Assign the value obtained of 
        // concatenation of the two string variables (add space if necessary) to this 
        // variable. Print the variable of type object.

        Console.WriteLine("====================Question 7====================");
        string firstWord = "Hello";
        string secondWord = "World";
        object concatenation = firstWord + " " + secondWord;

}

static void Casting()
{
        // Declare two variables of type string and give them values "Hello" and 
        // "World". Assign the value obtained by the concatenation of the two 
        // variables of type string (do not miss the space in the middle) to a 
        // variable of type object. Declare a third variable of type string and 
        // initialize it with the value of the variable of type object (you should use 
        // type casting)

        Console.WriteLine("=======================Question 8===================");
        string word1 = "Hello";
        string word2 = "World";
        object concatenate = word1 + " " + word2;
        string word3 = concatenate.ToString();
}

static void ConcatenateToString()
{
        // Declare two variables of type string and give them values "Hello" and 
        // "World". Assign the value obtained by the concatenation of the two 
        // variables of type string (do not miss the space in the middle) to a 
        // variable of type object. Declare a third variable of type string and 
        // initialize it with the value of the variable of type object (you should use 
        // type casting)

        Console.WriteLine("=======================Question 8===================");
        string word1 = "Hello";
        string word2 = "World";
        object concatenate = word1 + " " + word2;
        string word3 = concatenate.ToString();
   
}

static void QoutedString()
{
        // Declare two variables of type string and assign them a value “The 
        // "use" of quotations causes difficulties.” (without the outer quotes). 
        // In one of the variables use quoted string and in the other do not use it

        Console.WriteLine("=======================Question 9====================");
        string sentence = "The \"use\" of quotations causes difficulties";
        Console.WriteLine(sentence);

        string phrase = "\"The \"use\" of quotations causes difficulties\"";
        Console.WriteLine(phrase);

}

static void PrintHeartShape()
{
        // Write a program to print a figure in the shape of a heart by the sign "o".

        Console.WriteLine("=========================Question 10=================");
        Console.WriteLine("   o     o  ");
        Console.WriteLine("  o   o   o ");
        Console.WriteLine("  o       o ");
        Console.WriteLine("   o     o  ");
        Console.WriteLine("      o     ");


}

static void PrintIsocelesTriangle()
{
        // Write a program that prints on the console isosceles triangle which 
        // sides consist of the copyright character  "©".

        Console.WriteLine("===================Question 11=======================");
        Console.WriteLine("     ©    ");
        Console.WriteLine("   ©   ©  ");
        Console.WriteLine("  ©     © ");
        Console.WriteLine(" © © © © © ");

}

static void DataRecord()
{
        // A company dealing with marketing wants to keep a data record of its 
        // employees. Each record should have the following characteristic – first 
        // name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
        // (27560000 to 27569999). Declare appropriate variables needed to 
        // maintain the information for an employee by using the appropriate data 
        //types and attribute names.

        Console.WriteLine("====================Question 12=====================");
        Console.WriteLine("Enter your firstName: ");
        string firstName =(Console.ReadLine());
        Console.WriteLine("Enter your lastName: ");
        string lastName = (Console.ReadLine());
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your gender: ");
        string gender = (Console.ReadLine());
        Console.WriteLine("Enter your employee number: ");
        int num = int.Parse(Console.ReadLine());

}

static void SwapValues()
{
        // Declare two variables of type int. Assign to them values 5 and 10 
        // respectively. Exchange (swap) their values and print them

        Console.WriteLine("====================Question 13=====================");
        int x = 5;
        int y = 10;
        x = x + y;
        y = x - y;
        x = x - y;
        Console.WriteLine("x: {0} y: {1}", x, y);
}      

