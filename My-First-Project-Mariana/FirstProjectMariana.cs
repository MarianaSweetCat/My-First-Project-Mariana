// Mariana Alejandra López Rodríguez 2026-0911

try
{
    List<decimal> typedNumbers = new List<decimal>();
    bool running = true;

    Console.WriteLine("----WELCOME TO THE PROGRAM----");

    while (running)
    {
        Console.WriteLine("----------MAIN MENU----------");
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
                    // Calculator
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
                                // Addition
                                typedNumbers.Clear();

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

                                foreach (decimal number in typedNumbers)
                                {
                                    addition += number;
                                }
                                Console.WriteLine($"The result of the addition is: {addition}");

                            }
                            break;
                        case 2:
                            {
                                // Subtraction
                                typedNumbers.Clear();

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
                                // Multiplication
                                typedNumbers.Clear();

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
                                decimal multiplication = 1;

                                foreach (decimal number in typedNumbers)
                                {
                                    multiplication *= number;
                                }
                                Console.WriteLine($"The result of the multiplication is: {multiplication}");
                            }
                            break;
                        case 4:
                            {
                                // Division
                                typedNumbers.Clear();

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

                                    while (!decimal.TryParse(Console.ReadLine()!, out actualNumber) || (i > 1 && actualNumber == 0))
                                    {
                                        Console.WriteLine("Invalid input. Try Again");
                                    }

                                    typedNumbers.Add(actualNumber);
                                }

                                decimal division = typedNumbers[0];

                                for (int i = 1; i < typedNumbers.Count; i++)
                                {
                                    division /= typedNumbers[i];
                                }
                                Console.WriteLine($"The result of the division is: {division}");
                            }
                            break;
                        case 5:
                            {
                                // This case is intentionally empty. After the switch, the program returns to the main menu.
                            }
                            break;

                    }

                }
                break;

            case 2:
                {
                    // Grades Validation
                    typedNumbers.Clear();

                    Console.WriteLine("How many grades do you want to enter?");
                    int quantity;

                    while (!int.TryParse(Console.ReadLine()!, out quantity) || quantity < 1)
                    {
                        Console.WriteLine("Invalid input. Try Again");
                    }

                    for (int i = 1; i <= quantity; i++)
                    {
                        Console.WriteLine($"Enter grade {i}");

                        decimal actualGrade;

                        while (!decimal.TryParse(Console.ReadLine()!, out actualGrade) || actualGrade < 0 || actualGrade > 100)
                        {
                            Console.WriteLine("Invalid input. Try Again");
                        }

                        typedNumbers.Add(actualGrade);

                    }
                    
                    decimal sumGrades = 0;
                    
                    foreach (decimal number in typedNumbers)
                    {
                        sumGrades += number;
                    }

                    decimal gradePointAverage = sumGrades / quantity;

                    Console.WriteLine($"The Grade Point Average of the student is: {gradePointAverage:F2}");

                    if (gradePointAverage >= 90)
                    {
                        Console.WriteLine("The student passed. Congratulations! Excellent!");
                    }
                    else if (gradePointAverage >= 80)
                    {
                        Console.WriteLine("The student passed. Congratulations! Very good!");
                    }
                    else if (gradePointAverage >= 70)
                    {
                        Console.WriteLine("The student passed. Good job!");
                    }
                    else
                    {
                        Console.WriteLine("The student did not pass. Sorry. Keep trying.");
                    }

                }
                break;

            case 3:
                {      
                    // Exit 
                    Console.WriteLine("Are you sure you want to exit the program? (Yes or No)");
                    string answer = Console.ReadLine()!.ToLower();

                    while (answer != "yes" && answer != "no")
                    {
                        Console.WriteLine("Invalid input. Try Again");
                        answer = Console.ReadLine()!.ToLower();
                    }

                    if (answer == "yes")
                    {
                        Console.WriteLine("Thank you for using the program! :)\n" +
                            "The program has ended successfully.");
                        running = false;
                    }
                    
                }
                break;
        }
    }

}catch (Exception ex)

{

    Console.WriteLine($"Error: {ex.Message}");

    Console.WriteLine("The program could not be completed due to the error.");

}