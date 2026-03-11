// See https://aka.ms/new-console-template for more information

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