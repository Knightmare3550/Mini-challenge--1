Console.WriteLine("what is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}!");
Console.WriteLine("Welcome to Hamsterville!");
Console.WriteLine("Choose your hamster:");

Console.WriteLine("1. Nibbles");
Console.WriteLine("2. Peanut");
Console.WriteLine("3. Biscuit");
Console.WriteLine("4. Mochi");
Console.WriteLine("5. Mystery Hamster");
Console.Write("Enter a number from 1 to 5");

string choice = Console.ReadLine();
string[] hamsters = { "Nibbles", "Peanut", "Biscuit", "Mochi" };

string hamster;

switch (choice)
{
	case "1":
		hamster = "Nibbles";
		break;
	case "2":
		hamster = "Peanut";
		break;
	case "3":
		hamster = "Biscuit";
		break;
	case "4":
		hamster = "Mochi";
		break;
	case "5":
		hamster = hamsters[Random.Shared.Next(hamsters.Length)];
		break;
	default:
		hamster = "an unknown hamster";
		break;
}

Console.WriteLine($"You chose {hamster}!");
