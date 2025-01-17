// // declaring and printing a variable
// string fullName = "Poppy Peynado";
// Console.WriteLine(fullName);

// // reassigning variable
// fullName = "Knox Knocks";
// Console.WriteLine(fullName);

// // arithmetic operations
// int result = 5+3;
// Console.WriteLine(result);

// int num = 10;
// num--;
// Console.WriteLine(num);

// string greeting = "Coucou";
// string userName = "C'dawg";
// string message = greeting+" "+userName;
// Console.WriteLine(message);

// // interpolation
string message2 = $"greeting {userName} joining strings using interpolation";
Console.WriteLine(message2);

// collections:
// array
string[] fruits = new string[5];
fruits[0] = "apple";
fruits[1] = "clemintine";
fruits[2] = "strawberry";
fruits[3] = "banana";
fruits[4] = "kiwi";
Console.WriteLine(fruits[2]);

// string[] veg = {"carrot","cucumber","onion"};
// Console.WriteLine(veg[0]);
// Console.WriteLine($"{string.Join(", ", veg)}");

// lists:
// arrays and lists are ordered
// create an empty list
List<string> myPets = new List<string>();
myPets.Add("capybara");
myPets.Add("bear");
myPets.Add("bunny");
Console.WriteLine($"{string.Join(", ", myPets)}");

// create a list and populate the list with values
List<string> yourPets = new List<string>{"otter","cat","bird"};
Console.WriteLine($"{string.Join(", ", yourPets)}");
