// This is a comment to my code

//rakendus küsib kasutajalt sisestada tema nimi
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("enter your name:");
//string - sõna
String username;

username = Console.ReadLine();

Console.WriteLine("Hello" + ", " + username);
//string interpolation

firstname = "Harry";
lastname = "Potter";
Console.WriteLine($"Hello, {username}!");
Console.WriteLine("Hello, " + firstname + lastname);