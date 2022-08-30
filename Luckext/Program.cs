string name;
String howoldareyou;

name = ""; 

Console.WriteLine("Vad heter du?");
name = Console.ReadLine(); 

Console.WriteLine($"Hej {name}");
// Console.WriteLine(name);

Console.WriteLine("Hur gammal är du");
howoldareyou = Console.ReadLine(); 

Console.WriteLine($"Hej {name}, Okej {name} du är {howoldareyou} år "); 




Console.WriteLine("Tryck Enter för att avsluta");
Console.ReadLine();
