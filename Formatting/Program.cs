// See https://aka.ms/new-console-template for more information
using static System.Console;
//WriteLine("Hello, World!");

// int numberOfApples = 12;
// decimal pricePerApple = 0.35M;
// int a = 7;

// WriteLine(
//  format: "{0} apples {2} costs {1:C}",
//  arg0: numberOfApples,
//  arg1: pricePerApple * numberOfApples,
//  arg2: 9);

// string formatted = string.Format(
//  format: "{0} apples costs {1:C}",
//  arg0: numberOfApples,
//  arg1: pricePerApple * numberOfApples);

//  WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
 format: "{0,-10} {1,6}",
 arg0: "Name",
 arg1: "Count");

WriteLine(
 format: "{0,-10} {1,10:N0}",
 arg0: applesText,
 arg1: applesCount);

WriteLine(
 format: "{0,-10} {1,10:N0}",
 arg0: bananasText,
 arg1: bananasCount);


// Write("Type your first name and press ENTER: ");
// string? firstName = ReadLine();

// Write("Type your age and press ENTER: ");
// string? age = ReadLine();

// WriteLine( $"Hello {firstName}, you look good for {age}.");

// WriteLine();


//Write("Press any key combination: ");
//ConsoleKeyInfo key = ReadKey();
//WriteLine();
//WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
// arg0: key.Key,
// arg1: key.KeyChar,
// arg2: key.Modifiers);

//ReadLine();