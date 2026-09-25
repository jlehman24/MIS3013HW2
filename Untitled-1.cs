/*using System;

class SmartCheckoutSystem { static void Main(string[] args) { double totalPrice = 0; double itemPrice; int managerPin; const int correctPin = 1234;

    Console.WriteLine("=== Smart Checkout System ===");
    Console.WriteLine("Please enter the item price. (Enter 0 to finish the transaction).\n");
    
    Console.Write("Scan item price: $");
    itemPrice = Convert.ToDouble(Console.ReadLine());

    while (itemPrice != 0)
    {
        if (itemPrice >= 100)
        {
            Console.WriteLine($"\n! Manager approval required for high-value item ($100+) !");
            Console.Write("Manager, please enter override PIN: ");
            managerPin = Convert.ToInt32(Console.ReadLine());

            if (managerPin == correctPin)
            {
                Console.WriteLine("Correct PIN. Item is approved and added.\n");
                totalPrice += itemPrice;
            }
            else
            {
                Console.WriteLine("Incorrect PIN. Item is rejected and not added.\n");
            }
        }
        else
        {
            totalPrice += itemPrice;
            Console.WriteLine($"Item added.");
        }
        
        Console.Write("Scan item price: $");
        itemPrice = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine("\n==================");
    Console.WriteLine($"Your Receipt Total: ${totalPrice}");
    Console.WriteLine("Thank you for shopping with us!");
}
}

using System;

class PasswordCracker { static void Main(string[] args) { string correctPassword = "mis3013isgreat!"; string enteredPassword = ""; int maxAttempts = 3; int attemptsUsed = 0; bool isAccessGranted = false;

    do
    {
        Console.WriteLine("=== Password Cracker ===");
        Console.WriteLine("Please enter the security password:");
        enteredPassword = Console.ReadLine();

        if (enteredPassword == correctPassword)
        {
            Console.WriteLine("Access Granted.");
            isAccessGranted = true;
            attemptsUsed++;
        }
        else
        {
            attemptsUsed++;
            Console.WriteLine($"Incorrect. You have {maxAttempts - attemptsUsed} attempts remaining");
        }

    } while (!isAccessGranted && attemptsUsed < maxAttempts);

    if (isAccessGranted == false)
    {
        Console.WriteLine("Security Lockdown Initiated!");
    }
}
}*/

using System; using System.Threading;

class RocketLaunchPad { static void Main(string[] args) { for (int countdown = 10; countdown >= 1; countdown--) { Console.WriteLine(countdown + "...");

        if (countdown == 7)
        {
            Console.WriteLine("[SYSTEM]: Checking fuel levels... OK.");
        }

        if (countdown == 4)
        {
            Console.WriteLine("[SYSTEM]: Oxygen pressure... stabilized.");
        }

        if (countdown == 1)
        {
            Console.WriteLine("[SYSTEM]: Ignition sequence... START.");
        }
    }

    Console.WriteLine("0 - BLAST OFF!");
    
    Console.WriteLine("   |   ");
    Console.WriteLine("  / \\  ");
    Console.WriteLine(" / _ \\ ");
    Console.WriteLine(" |   | ");
    Console.WriteLine(" | (R) |");
    Console.WriteLine(" |_____| ");
    Console.WriteLine("  V V V  ");
    
    for (int time = 1; time <= 20; time++)
    {
        Console.WriteLine();
        Thread.Sleep(100); 
    }

    Console.WriteLine("Mission Success!");
}
}