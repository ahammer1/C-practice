// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
  List<Plant> plants = new List<Plant>
        {
            new Plant() {
            Species = "Ficus", 
            LightNeeds = 1, 
            AskingPrice = 15, 
            City = "Pasadena", 
            ZIP = "91101", 
            Sold = true },

            new Plant() { 
            Species = "Hydrangea", 
            LightNeeds = 3, 
            AskingPrice = 25, 
            City = "Walla Walla", 
            ZIP = "99362", 
            Sold = false },

            new Plant() { 
            Species = "Snake Plant", 
            LightNeeds = 2, 
            AskingPrice = 12, 
            City = "Los Angeles", 
            ZIP = "90001", 
            Sold = false },

            new Plant() { 
            Species = "Rose", 
            LightNeeds = 5, 
            AskingPrice = 20, 
            City = "New York", 
            ZIP = "10001", 
            Sold = true },

            new Plant() { 
            Species = "Peace Lily", 
            LightNeeds = 4, 
            AskingPrice = 18, 
            City = "Chicago", 
            ZIP = "60601", 
            Sold = false }
        };

string greeting = @"Welcome to the Plant App!
Here is a List of Available Plants:";

Console.WriteLine(greeting);


string? choice = null;

while (choice != "0") 
{
  Console.WriteLine(@"Choose the following options:
  0.Exit
  1.Display all plants
  2. Post a plant to be adopted
  3. Adopt a plant
  4.Delist a plant");
  choice = Console.ReadLine();
  
  if (choice == "0")
  {
    Console.WriteLine("leave");
  }
  else if (choice == "1")
  {
    Console.WriteLine("Display all plants");
  }
  else if (choice == "2")
  {
    Console.WriteLine("Post a plant to be adopted");
  }
  else if (choice == "3")
  { 
    Console.WriteLine("Adopt a plant");
  }
  else if (choice == "4")
  {
    Console.WriteLine ("Delist a Plant");
  } 
  else {
    Console.WriteLine ("Do Better");
  }
}
