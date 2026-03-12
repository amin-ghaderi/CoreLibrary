// See https://aka.ms/new-console-template for more information


// 2026-03-12 Dice gambling game



// ===============================
// GAME SETUP
// Initialize core game state and tools
// ===============================
Random random = new Random();

int credits = 100;
int lives = 3;


// ===============================
// MAIN GAME LOOP
// The game continues until the player
// loses three lives or runs out of credits
// ===============================
while (lives > 0 && credits > 0)
{
    Console.WriteLine("New round started");


    // ===============================
    // BET INPUT
    // Ask the player to choose a valid bet
    // Allowed values: 10, 30, or 50
    // ===============================

    int bet;

    while (true)
    {
        //Console.WriteLine($"Credits: {credits}");
        // REFACTOR 3 (2026-03-12 12:48 | Amin)
        // Improved player input feedback by displaying both remaining lives
        // and available credits before asking for the bet.
        // This helps the player understand the current game state
        // before making a betting decision.
        Console.WriteLine($"Lives: {lives} | Credits: {credits}");
        Console.Write("Enter bet (10, 30, 50): ");

        //bet = int.Parse(Console.ReadLine());
        // REFACTOR 4 (2026-03-12 13:04 | Amin)
        // Replaced int.Parse(Console.ReadLine()) with int.TryParse()
        // to prevent runtime crashes when the user enters non-numeric input
        // and to remove the CS8604 nullability warning.
        // This improves input safety and code robustness without changing
        // the game logic or behavior.

        string? input = Console.ReadLine();

        if (!int.TryParse(input, out bet))
        {
            Console.WriteLine("Invalid number. Try again.");
            continue;
        }

        if ((bet == 10 || bet == 30 || bet == 50) && bet <= credits)
        {
            break;
        }

        Console.WriteLine("Invalid bet. Try again.");
    }

    Console.WriteLine($"You bet: {bet}");
    Console.WriteLine();
    // REFACTOR 7 (2026-03-12 13:16 | Amin)
    // Removed duplicated "You bet" output from BET INPUT section.
    // The bet is now displayed only in the round result section
    // to avoid duplicate messages.
    


    // ===============================
    // DICE ROLL
    // Generate a random dice value (1–6)
    // ===============================
    int dice = random.Next(1, 7);
    bool playerLost = dice <= 2;



    // ===============================
    // RESULT EVALUATION
    // Determine if the player wins or loses
    // based on the dice result
    // ===============================
    if (playerLost)
    {
        Console.WriteLine("You lost a life!");
        lives--;
        credits -= bet;
    }
    else
    {
        Console.WriteLine("You won!");
        credits += bet * 2;
    }



    // ===============================
    // UPDATE GAME STATE
    // Apply changes to lives and credits
    // ===============================
    // Console.WriteLine($"You bet: {bet}");
     //Console.WriteLine();
     // REFACTOR 7 (2026-03-12 13:16 | Amin)
     // Removed duplicated "You bet" output from BET INPUT section.
     // The bet is now displayed only in the round result section
     // to avoid duplicate messages.
    

     Console.WriteLine($"Dice rolled: {dice}");
        // REFACTOR 1 (2026-03-12 12:28 – Amin)
        // Removed duplicated result message.
        // Result is now printed only once in RESULT EVALUATION section
        // to avoid duplicate output.
        /*
     if (dice == 1 || dice == 2)
     {
     Console.WriteLine("You lost a life!");
     }
     else
     {
      Console.WriteLine("You won!");
     }*/

     Console.WriteLine();
     Console.WriteLine($"Lives: {lives}");
     Console.WriteLine($"Credits: {credits}");
     Console.WriteLine();

     //Console.WriteLine("Press Enter to roll again...");
     //Console.ReadLine();
     // REFACTOR 6 (2026-03-12 | Amin)
     // Removed duplicated "Press Enter to roll again" pause.
     // The game now pauses only once at the end of each round.

    
    



    

    // ===============================
    // NEXT ROUND CONTROL
    // Pause the game so the player can
    // review the result before continuing
    // ===============================
    Console.WriteLine("Press Enter to roll again...");
    Console.ReadLine();
}


// ===============================
// GAME OVER
// Display the final result after the loop ends
// ===============================
Console.WriteLine("Game over");
Console.WriteLine($"Final credits: {credits}");









/*
// Wednesday 2026-03-11 Determined Loop exercise No. 1

int[] amount = [5506, 291, 500, 482, 963];
int total = 0;
for (int i = 0; i < amount.Length; i++)
{
    int before = total;
    total = total + amount[i];
    Console.WriteLine($"Step {i}: {before} + {amount[i]} = {total}");
}
Console.WriteLine($"Final total is {total}");   


// Wednesday 2026-03-11 Determined Loop exercise No. 2

Console.WriteLine("Enter some text:");
string[] text = (Console.ReadLine() ??"").Split(" ");
for (int i = 0; i < text.Length; i ++)
if (i % 2 == 0)
{
    Console.Write($"{text[i].ToUpper()} ");
}
else
{
    Console.Write($"{text[i].ToLower()} ");
}

// Wednesday 2026-03-11 Determined Loop exercise No. 3

Console.WriteLine("Enter some text:");
string[] text = (Console.ReadLine() ??"").Split(" ");
for (int i = 0; i < text.Length; i ++)
if (text[i].Length >= 6)
{
    Console.Write($"{text[i]} (long word) ");
}
else
{
    Console.Write($"{text[i]} ");
}

// Wednesday 2026-03-11 Determined Loop exercise No. 4

Console.WriteLine("Enter some text:");
string[] text = (Console.ReadLine() ??"").Split(" ");
for (int i = 0; i < text.Length; i ++)
{
    for (int j = 0; j < text[i].Length; j++)
    {
        Console.Write($"{text[i]} ");
    }
    Console.WriteLine();
}

/*
// tuesday 2026-03-10 conditional flow exercise No. 1

Console.WriteLine("Are you gluten free?");
string response = (Console.ReadLine() ?? "").ToLower(); 
if (response == "yes")
{
    Console.WriteLine("You will be served gluten free food");
}
else if (response == "no") 
{
    Console.WriteLine("The regular menu will apply");
}
else
{
    Console.WriteLine("Unable to decide preference");
}


// tuesday 2026-03-10 conditional flow exercise No. 2

Console.WriteLine("please enter some text");
string response1 = (Console.ReadLine() ?? "").ToLower(); 
if (response1.Contains("drop database"))
{
    Console.WriteLine("Error 103: unable to process");
}


// tuesday 2026-03-10 conditional flow exercise No. 3

Console.WriteLine("Please enter a password:");
string password = Console.ReadLine() ?? "";
Console.WriteLine("Please enter your email:");
string email = Console.ReadLine() ?? "";


if (password.Length < 7)
{
    Console.WriteLine(" the password is not seven characters or longer that is must be so");
}

bool isValidEmail = email.EndsWith(".se") || email.EndsWith(".com");
if (!isValidEmail)
{
    Console.WriteLine("Only .se or .com email addresses are accepted");
}
if (password.Length >= 7 && isValidEmail)
{
    Console.WriteLine("Account has been created");
}

// tuesday 2026-03-10 conditional flow exercise No. 4

Console.WriteLine("Enter a sentence with at least seven words in it");
string sentence = Console.ReadLine() ?? "";
string[] words = sentence.Split(" ");
if (words.Length < 7)
{
    Console.WriteLine("Not a correct sentence");
}
else
{
    Console.WriteLine("Sentence accepted");
}

// tuesday 2026-03-10 conditional flow exercise No. 5

Console.WriteLine("what is your name?");
string name = Console.ReadLine() ?? "";

if (name.StartsWith("Lord"))

{
    Console.WriteLine("Welcome Your Excellency");
}
else
{
    Console.WriteLine("Welcome " + name);
}



/*
// monday 2026-03-09
Console.WriteLine("which music instrument do you like?");
//Console.ReadLine();
string instrument  = Console.ReadLine() ?? "";
Console.WriteLine("Can you play the " + instrument + "?");
string answer  = Console.ReadLine() ?? "";
Console.WriteLine(answer + " ?"+ " NO PROBLEM! " + "I also like the " + instrument + " !");


Console.WriteLine("whats your last name?");
string lastname = Console.ReadLine() ?? "";
Console.WriteLine("whats your first name?");
//Console.ReadLine();
string firstname = Console.ReadLine() ?? "";
Console.WriteLine(firstname.ToUpper() + " " + lastname.ToUpper() + " joined the firm " );



Console.WriteLine("whats your full name?");
//Console.ReadLine();
string fullname = Console.ReadLine() ?? "";
string [] names = fullname.Split(" ");
Console.WriteLine(names[1].ToUpper() +", "+names[0].ToLower() + " " + ": present" );
*/