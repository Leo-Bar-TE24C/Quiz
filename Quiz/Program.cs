int score = 0;
Console.WriteLine("Welcom to the Phoenix Wright quiz");



Console.WriteLine("What is Phoenix Wright's assinstant named?");
Console.WriteLine("A) Miles \nB) Manta \nC) Maya");
string q2 = Console.ReadLine().ToLower();

while (q2 != "a" && q2 != "b" && q2 != "c")
{
    Console.WriteLine("Sorry thats not an option, try again");
    Console.WriteLine("A) Miles \nB) Manta \nC) Maya");
    q2 = Console.ReadLine().ToLower();
}

if (q2 == "c")
{
    Console.WriteLine("Correct!");
    score += 10;
}
else
{
    Console.WriteLine("Wrong");
    score -= 5;
}


Console.WriteLine("What is Phoenix Wright's tie color?");
Console.WriteLine("A) Red  \nB) Yellow  \nC) Green");
string q3 = Console.ReadLine().ToLower();

while (q3 != "a" && q3 != "b" && q3 != "c")
{
    Console.WriteLine("Sorry thats not an option, try again");
    Console.WriteLine("A) Red  \nB) Yellow  \nC) Green");
    q3 = Console.ReadLine().ToLower();
}

if (q3 == "a")
{
    Console.WriteLine("Correct!");
    score += 10;
}
else
{
    Console.WriteLine("Wrong");
    score -= 5;
}

Console.WriteLine("Has phoenix Wright questioned a parrot?");
Console.WriteLine("A) Yes \nB) No");
string q1 = Console.ReadLine().ToLower();

while (q1 != "a" && q1 != "b")
{
    Console.WriteLine("Sorry thats not an option, try again");
    Console.WriteLine("A) Yes \nB) No");
    q1 = Console.ReadLine().ToLower();
}

if (q1 == "a")
{
    Console.WriteLine("Correct!");
    score += 10;
}
else
{
    Console.WriteLine("Wrong");
    score -= 5;
}
if (score < 10)
{
    Console.WriteLine($"Better luck next time, you got {score} points");
}
else
{
    Console.WriteLine($"Congratulations you got {score} points");
}
    Console.ReadLine();