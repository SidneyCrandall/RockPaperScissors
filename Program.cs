using System;

// Game of Rock, Paper, Scissors, but in the terminal.
void HandThrow(int pick)
{
    if (pick == 1)
    {
        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
        ");
    }
    if (pick == 2)
    {
        Console.WriteLine(@"
     _______
-- - '  ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
    }
    if (pick == 3)
    {
        Console.WriteLine(@"
    _______
-- - '   ____)____
            ______)
       __________)
      (____)
-- -.__(___)
    ");
    }
}

int personscore = 0; 
int computerscore = 0;

Shoot ();
void Shoot()
{
    // Clears the console after each round for a new turn
    Console.Clear();
    if (personscore == 3)
    {
        Console.WriteLine("You win!!");
    }
    else if (computerscore == 3)
    {
        Console.WriteLine("You Lost!");
    }
    else 
    {
        // terminal display of the score board
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"|Player: {personscore} | Computer: {computerscore} |");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("What would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");

        string pick = Console.ReadLine();
        // suspends the thread for a number of specified seconds
        // "It also provides different types of method to perform various operations"
        int personpick = Int32.Parse(pick);

        Random i = new Random();
        int computerpick = i.Next(1, 3);
        HandThrow(personpick);
        Console.WriteLine("VS");
        HandThrow(computerpick);
        // "Threads are independent execution paths, able to run simultaneously."
        // We are waiting a specific timespan for when we should continue 
        System.Threading.Thread.Sleep(750);

        if (personpick == computerpick)
        {
            Shoot();
        }
        else if (personpick == 1)
        {
            if (computerpick == 2)
            {
                computerscore++;
                Shoot();
            }
            else 
            {
                personscore++;
                Shoot();
            }
        }
        else if (personpick == 2)
        {
            if (computerpick == 3)
            {
                computerscore++;
                Shoot();
            }
            else 
            {
                personscore++;
                Shoot();
            }
        }
        else if ( personpick == 3)
        {
            if (computerpick == 1)
            {
                computerscore++;
                Shoot();
            }
            else 
            {
                personscore++;
                Shoot();
            }
        }
    }
}
