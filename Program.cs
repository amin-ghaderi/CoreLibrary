// See https://aka.ms/new-console-template for more information


// 2026-03-24 Exception Handling no. 3



int[] numbers = { 10, 0 };

//index error
try
{
    int num = numbers[2];
}
catch (Exception ex)
{
    Console.WriteLine("First error: " + ex.Message);
}

//divide error
try
{
    int result = numbers[0] / numbers[1];
}
catch (Exception ex)
{
    Console.WriteLine("Second error: " + ex.Message);
}

// 2026-03-24 Exception Handling no. 2


int tryNumber = 0;

try
{
    Console.WriteLine("Enter a Zero!!:");
    string tryEntry = Console.ReadLine() ?? "";
    tryNumber = 100 / int.Parse(tryEntry);
}

catch (DivideByZeroException ex)
{
    Console.WriteLine("Message: " + ex.Message);
    // Console.WriteLine("Source: " + ex.Source);
}


// 2026-03-24 Exception Handling no. 1


int tryNumber1 = 0;

try
{
    Console.WriteLine("Enter a number:");
    string tryEntry = Console.ReadLine() ?? "";
    tryNumber1 = int.Parse(tryEntry);
}
catch (Exception ex)
{
    Console.WriteLine("Message: " + ex.Message);
    // Console.WriteLine("Source: " + ex.Source);
}






/*
// 2026-03-23 Parsing

Console.WriteLine("Enter a number:");
string input = Console.ReadLine() ?? "";
int age = int.TryParse(input, out int parsedAge) ? parsedAge : 0;

Console.WriteLine(age + 25);


string dateText = "2026-03-23  12:30:45";
DateTime date = DateTime.Parse(dateText);
Console.WriteLine(date);

string isActiveText = "true";
bool isActive = bool.TryParse(isActiveText, out bool parsedIsActive) ? parsedIsActive : false;
Console.WriteLine(isActive);

// 2026-03-23 list and flexible conections exercises No. 2 , 3

List<Tool> tools = new List<Tool>()
{
    new Tool() { Brand = "Bosch", Name = "Drill" },
    new Tool() { Brand = "Makita", Name = "Grinder" },
    new Tool() { Brand = "DeWalt", Name = "Driver" }
};

tools.RemoveAt(1);

foreach (Tool tool in tools)
{
    Console.WriteLine($"Brand: {tool.Brand}");
}

tools.Add(new Tool() { Brand = "Hilti", Name = "Hammer" });
tools.Add(new Tool() { Brand = "Milwaukee", Name = "Saw" });

var found = tools.Find(t => t.Name == "Hammer");
if (found != null)
{
    Console.WriteLine($"FOUND -> Brand: {found.Brand}, Name: {found.Name}");
}

foreach (Tool tool in tools)
{
    Console.WriteLine($"Brand: {tool.Brand}, Name: {tool.Name}");
}



// 2026-03-23 list and flexible conections exercises No. 1



List<string> words = new List<string>()
{
    "Tehran",
    "Stockholm",
    "Paris",
    "Berlin"
};

words.Sort();

foreach (string word in words)
{
    Console.WriteLine(word);
}

class Tool
{
    public string Brand="";
    public string Name="";
}


/*

// 2026-03-17 class exercises on classes and objects



Employee Amin = new Employee(20000m);
Employee Tobias = new Employee(50000m);

Console.WriteLine($"Amin Tax: {Amin.IncomeTax()}");
Console.WriteLine($"Tobias Tax: {Tobias.IncomeTax()}");

class Employee
{
    private decimal salary;

    public Employee()
    {
    }

    public Employee(decimal salary)
    {
        this.salary = salary;
    }

    public decimal IncomeTax()
    {
        int vacationDays = VacationDays();
        decimal tax = salary * 0.3m * (20 - vacationDays);
        return tax;
    }

    private int VacationDays()
    {
        return 5;
    }
}


/*
// ==========================================
// Exercise: Methods
// Exercise Number: 1
// Description: Move the password checking code
// into a separate method and call the method
// from the main program.
// Date: 16-03-2026
// ==========================================

// Method
bool CheckPassword(string password)
{
    return password.ToLower() == "pencil";
}

// Main code
Console.WriteLine("Enter your password:");
string password = Console.ReadLine() ?? "";

bool passwordMatch = CheckPassword(password);

if (passwordMatch)
{
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Login failed");
}

// ==========================================
// Course: C# Programming
// Topic: Methods
// Exercise: 2
// Date: 16-03-2026
// Description:
// Move the highlighted login code into a
// separate method and call the method
// from the main program.
// ==========================================



// Method
int FindUser(string[][] users, string username)
{
    int userMatch = -1;

    for (int i = 0; i < users.Length; i++)
    {
        if (users[i][0] == username.ToLower())
        {
            userMatch = i;
        }
    }

    return userMatch;
}

// Main code
string[][] users =
[
    ["john", "plate"],
    ["michelle", "bike"],
    ["lisa", "pencil"]
];

Console.WriteLine("Enter your username:");
string username = Console.ReadLine() ?? "";

Console.WriteLine("Enter your password:");
string password = Console.ReadLine() ?? "";

int userMatch = FindUser(users, username);

bool passwordMatch = false;

if (userMatch > -1)
{
    passwordMatch = password.ToLower() == users[userMatch][1];
}

if (passwordMatch)
{
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Login failed");
}

// ==========================================
// Course: C# Programming
// Topic: Methods
// Exercise: 3
// Author: Amin
// Date: 16-03-2026
// Description:
// Break the login code into several methods
// and call them from the main program.
// ==========================================


// user database
string[][] users =
[
    ["john", "plate"],
    ["michelle", "bike"],
    ["lisa", "pencil"]
];

string username = GetUsername();
string password = GetPassword();

int userMatch = FindUser(users, username);

bool passwordMatch = CheckPassword(users, userMatch, password);

ShowResult(passwordMatch);



// ==========================================
// GET USERNAME
// Ask user for username
// ==========================================

string GetUsername()
{
    Console.WriteLine("Enter your username:");
    return Console.ReadLine();
}



// ==========================================
// GET PASSWORD
// Ask user for password
// ==========================================

string GetPassword()
{
    Console.WriteLine("Enter your password:");
    return Console.ReadLine();
}



// ==========================================
// FIND USER
// Search username in user array
// ==========================================

int FindUser(string[][] users, string username)
{
    int userMatch = -1;

    for (int i = 0; i < users.Length; i++)
    {
        if (users[i][0] == username.ToLower())
        {
            userMatch = i;
        }
    }

    return userMatch;
}



// ==========================================
// CHECK PASSWORD
// Compare entered password with stored one
// ==========================================

bool CheckPassword(string[][] users, int userMatch, string password)
{
    bool passwordMatch = false;

    if (userMatch > -1)
    {
        passwordMatch = password.ToLower() == users[userMatch][1];
    }

    return passwordMatch;
}



// ==========================================
// SHOW RESULT
// Display login result
// ==========================================

void ShowResult(bool passwordMatch)
{
    if (passwordMatch)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Login failed");
    }
}



// ==========================================
// Course: C# Programming
// Topic: Methods
// Exercise: 4
// Author: Amin
// Date: 16-03-2026
// Description:
// Write a method that takes a string array
// and returns the length of the longest string.
// ==========================================


// sample array
string[] words = { "cat", "computer", "book", "phone" };

int longestLength = GetLongestLength(words);

Console.WriteLine("Longest length: " + longestLength);



// ==========================================
// GET LONGEST STRING LENGTH
// Find the longest word in array
// ==========================================

int GetLongestLength(string[] words)
{
    int maxLength = 0;

    for (int i = 0; i < words.Length; i++)
    {
        int length = words[i].Length;

        if (length > maxLength)
        {
            maxLength = length;
        }
    }

    return maxLength;
}


// ==========================================
// Course: C# Programming
// Topic: Methods
// Exercise: 5
// Author: Amin
// Date: 16-03-2026
// Description:
// Write a method that takes three integers,
// adds the first two numbers and compares
// the result with the third number.
// ==========================================


// sample numbers
bool result = CompareNumbers(4, 5, 7);

Console.WriteLine(result);



// ==========================================
// COMPARE NUMBERS
// Add first two numbers and compare with third
// ==========================================

bool CompareNumbers(int a, int b, int c)
{
    int sum = a + b;

    if (sum > c)
    {
        return true;
    }
    else
    {
        return false;
    }
}









/*
// ==========================================
// COFFEE SHOP ORDER SYSTEM 2026-03-13
// Multi Conditional Flow Exercise
// ==========================================


// ------------------------------------------
// VARIABLES – HOLD ORDER DATA
// ------------------------------------------

string coffeeName = "";
string size = "";
string extra = "";

double price = 0;


// ------------------------------------------
// STEP 1 – DISPLAY FULL COFFEE MENU
// user sees sizes and prices immediately
// ------------------------------------------

// ===== CAFE TITLE =====
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("==============================================");
Console.WriteLine("             AX ODCYC COFFEE BAR");
Console.WriteLine("==============================================");
Console.ResetColor();


// ===== MENU HEADER =====
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("HOT BREWS                  250ml      350ml");
Console.WriteLine("------------------------------------------------");
Console.ResetColor();


// ===== MENU ITEMS =====

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("a  ");
Console.ResetColor();
Console.WriteLine("Espresso                1.95");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("b  ");
Console.ResetColor();
Console.WriteLine("Double Espresso         2.85");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("c  ");
Console.ResetColor();
Console.WriteLine("Espresso Macchiato      2.25");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("d  ");
Console.ResetColor();
Console.WriteLine("Americano               2.50       3.00");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("e  ");
Console.ResetColor();
Console.WriteLine("Lungo                   2.50");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("f  ");
Console.ResetColor();
Console.WriteLine("Flat White              2.50       3.00");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("g  ");
Console.ResetColor();
Console.WriteLine("Cappuccino              2.50       3.00");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("h  ");
Console.ResetColor();
Console.WriteLine("Hot Chocolate           3.50       4.00");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("i  ");
Console.ResetColor();
Console.WriteLine("Mocha                   4.00       4.50");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("j  ");
Console.ResetColor();
Console.WriteLine("Latte Macchiato         3.00       3.50");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("k  ");
Console.ResetColor();
Console.WriteLine("Decaffeinated Espresso  2.50");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("l  ");
Console.ResetColor();
Console.WriteLine("Tea                     1.85");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("m  ");
Console.ResetColor();
Console.WriteLine("Herbal Tea              2.10");


// ===== FOOTER =====
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("------------------------------------------------");
Console.ResetColor();

Console.WriteLine("Choose coffee (a-m):");

string coffeeChoice = Console.ReadLine() ?? "";


// ------------------------------------------
// STEP 2 – HANDLE COFFEE TYPE
// determine coffee name, base price
// ask size if 350ml exists
// ------------------------------------------

switch (coffeeChoice)
{
    case "a":

        coffeeName = "Espresso";
        size = "250ml";
        price = 1.95;

        break;

    case "b":

        coffeeName = "Double Espresso";
        size = "250ml";
        price = 2.85;

        break;

    case "c":

        coffeeName = "Espresso Macchiato";
        size = "250ml";
        price = 2.25;

        break;

    case "d":

        coffeeName = "Americano";

        Console.WriteLine("Choose size: a 250ml | b 350ml");
        string sizeChoice = Console.ReadLine() ?? "";

        switch (sizeChoice)
        {
            case "a":
                size = "250ml";
                price = 2.50;
                break;

            case "b":
                size = "350ml";
                price = 3.00;
                break;
        }

        break;

    case "e":

        coffeeName = "Lungo";
        size = "250ml";
        price = 2.50;

        break;

    case "f":

        coffeeName = "Flat White";

        Console.WriteLine("Choose size: a 250ml | b 350ml");
        sizeChoice = Console.ReadLine() ?? "";

        switch (sizeChoice)
        {
            case "a":
                size = "250ml";
                price = 2.50;
                break;

            case "b":
                size = "350ml";
                price = 3.00;
                break;
        }

        break;

    case "g":

        coffeeName = "Cappuccino";

        Console.WriteLine("Choose size: a 250ml | b 350ml");
        sizeChoice = Console.ReadLine() ?? "";

        switch (sizeChoice)
        {
            case "a":
                size = "250ml";
                price = 2.50;
                break;

            case "b":
                size = "350ml";
                price = 3.00;
                break;
        }

        break;

    case "h":

        coffeeName = "Hot Chocolate";

        Console.WriteLine("Choose size: a 250ml | b 350ml");
        sizeChoice = Console.ReadLine() ?? "";

        switch (sizeChoice)
        {
            case "a":
                size = "250ml";
                price = 3.50;
                break;

            case "b":
                size = "350ml";
                price = 4.00;
                break;
        }

        break;

    case "i":

        coffeeName = "Mocha";

        Console.WriteLine("Choose size: a 250ml | b 350ml");
        sizeChoice = Console.ReadLine() ?? "";

        switch (sizeChoice)
        {
            case "a":
                size = "250ml";
                price = 4.00;
                break;

            case "b":
                size = "350ml";
                price = 4.50;
                break;
        }

        break;

    case "j":

        coffeeName = "Latte Macchiato";

        Console.WriteLine("Choose size: a 250ml | b 350ml");
        sizeChoice = Console.ReadLine() ?? "";

        switch (sizeChoice)
        {
            case "a":
                size = "250ml";
                price = 3.00;
                break;

            case "b":
                size = "350ml";
                price = 3.50;
                break;
        }

        break;

    case "k":

        coffeeName = "Decaffeinated Espresso";
        size = "250ml";
        price = 2.50;

        break;

    case "l":

        coffeeName = "Tea";
        size = "250ml";
        price = 1.85;

        break;

    case "m":

        coffeeName = "Herbal Tea";
        size = "250ml";
        price = 2.10;

        break;

    default:

        Console.WriteLine("Invalid coffee selection");

        break;
}


// ------------------------------------------
// STEP 3 – EXTRAS MENU
// ------------------------------------------
// ===== CAFE TITLE =====
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("==============================================");
Console.WriteLine("             AX ODCYC COFFEE BAR");
Console.WriteLine("==============================================");
Console.ResetColor();


// ===== EXTRAS HEADER =====
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("EXTRAS");
Console.WriteLine("------------------------------------------------");
Console.ResetColor();


// ===== EXTRA ITEMS =====

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("a  ");
Console.ResetColor();
Console.WriteLine("Additional Syrup Topping           +1.50");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("b  ");
Console.ResetColor();
Console.WriteLine("Additional Cream                   +1.50");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("c  ");
Console.ResetColor();
Console.WriteLine("Soya / Almond / Lactose-Free Milk  +1.00");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("d  ");
Console.ResetColor();
Console.WriteLine("No extra");


// ===== FOOTER =====
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("------------------------------------------------");
Console.ResetColor();

Console.WriteLine("Choose extra:");
string extraChoice = Console.ReadLine() ?? "";


// ------------------------------------------
// STEP 4 – HANDLE EXTRA OPTION
// ------------------------------------------

switch (extraChoice)
{
    case "a":

        extra = "Additional Syrup Topping";
        price += 1.50;

        break;

    case "b":

        extra = "Additional Cream";
        price += 1.50;

        break;

    case "c":

        extra = "Soya / Almond / Lactose-Free Milk";
        price += 1.00;

        break;

    case "d":

        extra = "No extra";

        break;

    default:

        Console.WriteLine("Invalid extra option");

        break;
}


// ------------------------------------------
// STEP 5 – PRINT FINAL ORDER
// ------------------------------------------
Console.WriteLine("");

Console.WriteLine("AX ODCYC COFFEE BAR");
Console.WriteLine("--------------------------------");

Console.WriteLine($"{coffeeName} {size}");
Console.WriteLine($"{extra}");

Console.WriteLine("--------------------------------");

Console.WriteLine($"TOTAL   {price:F2}");

















/*

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
     }

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







*/

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