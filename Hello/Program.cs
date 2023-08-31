Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("Vad heter du?");

string name = Console.ReadLine();

Console.WriteLine($"hej {name} vad snygg de är idag!");

Console.WriteLine("Vad är din favorit Sport?");
string sport = Console.ReadLine();


Console.WriteLine($"Nice, {sport} är en bra sport.");

Console.WriteLine("Vad är ditt favorit djur?");
string djur = Console.ReadLine();


Console.WriteLine($"{djur} är coola djur");

Console.ReadLine();