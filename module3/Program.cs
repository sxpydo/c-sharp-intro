// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Comparison operators
// int age = 23;
// Console.WriteLine(5==5);
// Console.WriteLine(5>=5);

//code along

// int first = 23;
// int second = 10;

// Console.WriteLine(first==second);
// Console.WriteLine(first>=second);
// Console.WriteLine("ten"!=second);
// Console.WriteLine(10==second);

// Condtional statements
using System.Runtime.CompilerServices;

int age = 10;
if (age >=18){
Console.WriteLine("you are eligible to vote");
}
else
{Console.WriteLine("you are not eligible to vote");
};

// Logical operators
bool dog = true;
bool cat = true;

if (dog || cat) {
    Console.WriteLine("You have choosen a dog or a cat!");
} else {
    Console.WriteLine("Please choose one..");
}

bool raining = false;
if (!raining) {
    Console.WriteLine("It's not raining");
} else {
    Console.WriteLine("It is raining!");
}
