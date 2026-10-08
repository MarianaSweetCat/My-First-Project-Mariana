try
{
    List<decimal> typedNumbers = new List<decimal>();
    bool running = true;

    Console.WriteLine("-----WELCOME TO THE PROGRAM-----");

    while (running)
    {
        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Grades validation");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Choose an option (1 - 3):");
        int option;

        while (!int.TryParse(Console.ReadLine()!, out option) || option < 1 || option > 3)
        {
            Console.WriteLine("Invalid input. Try Again");
        }

        switch (option)
        {
            case 1:
                {
                    Console.WriteLine("----CALCULATOR----");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Return");
                    Console.WriteLine("Choose an option (1 - 5):");
                    int typedOption;

                    while (!int.TryParse(Console.ReadLine()!, out typedOption) || typedOption < 1 || typedOption > 5)
                    {
                        Console.WriteLine("Invalid input. Try Again");
                    }

                    switch (typedOption)
                    {
                        case 1:
                            {
                                Console.WriteLine("How many numbers do you want to use?");
                                int quantity;

                                while (!int.TryParse(Console.ReadLine()!, out quantity) || quantity < 2)
                                {
                                    Console.WriteLine("Invalid input. Try Again");
                                }

                                for (int i = 1; i <= quantity; i++)
                                {
                                    Console.WriteLine($"Enter number {i}");

                                    decimal actualNumber;

                                    while (!decimal.TryParse(Console.ReadLine()!, out actualNumber))
                                    {
                                        Console.WriteLine("Invalid input. Try Again");
                                    }

                                    typedNumbers.Add(actualNumber);

                                }
                                decimal addition = 0;

                                foreach (decimal Number in typedNumbers)
                                {
                                    addition += Number;
                                }
                                Console.WriteLine($"The result of the addition is: {addition}");

                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("How many numbers do you want to use?");
                                int quantity;

                                while (!int.TryParse(Console.ReadLine()!, out quantity) || quantity < 2)
                                {
                                    Console.WriteLine("Invalid input. Try Again");
                                }

                                for (int i = 1; i <= quantity; i++)
                                {
                                    Console.WriteLine($"Enter number {i}");

                                    decimal actualNumber;

                                    while (!decimal.TryParse(Console.ReadLine()!, out actualNumber))
                                    {
                                        Console.WriteLine("Invalid input. Try Again");
                                    }

                                    typedNumbers.Add(actualNumber);
                                }
                                
                                decimal subtraction = typedNumbers[0];
                                
                                for (int i = 1; i < typedNumbers.Count; i++)
                                {
                                    subtraction -= typedNumbers[i];
                                }
                                    Console.WriteLine($"The result of the subtraction is: {subtraction}");



                                
                            }
                            break;
                        case 3:
                            {

                            }
                            break;
                        case 4:
                            {

                            }
                            break;
                        case 5:
                            {

                            }
                            break;

                    }



                }
                break;

            case 2:
                {

                }
                break;

            case 3:
                {

                }
                break;
        }


    }

}catch (Exception ex)

{

    Console.WriteLine($"Error: {ex.Message}");

    Console.WriteLine("The program could not be completed due to the error.");

}


/* Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Calculate student grades");
Console.WriteLine("6.Exit");

Console.WriteLine("Choose an option (1 - 6)");
int typedOption = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the first number: ");
typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

Console.WriteLine("Enter the second number");
typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

var wantToContinue = true;

Console.WriteLine("Do you wish to continue with another math operation? 1.Yes 2.No");
var userInput = int.Parse(Console.ReadLine());

if (userInput == 1)
{
    wantToContinue = true;
}
else if (userInput == 2 || userInput == 3)
{
    wantToContinue = false;
}
else
{
    wantToContinue = false;
}

wantToContinue = (int.Parse(Console.ReadLine()) == 1);

while (wantToContinue)
{
    Console.WriteLine("Enter a new number:");
    typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

    Console.WriteLine("Do you wish to continue with another math operation? 1.Yes 2.No");
    wantToContinue = (int.Parse(Console.ReadLine()) == 1);
}

decimal result = 0;

switch (typedOption)
{
    case 1:
        {
            for (int i = 0; i < typedNumbers.Count; i++)
            {
                result = result + typedNumbers[i];
            }
        }
        break;

    case 2:
        {
            foreach (var item in typedNumbers)
        }


        break;

    case 3:


        break;


    case 4:

        break;

    case 5:


        break;

    case 6:

        break;


}*/