// See https://aka.ms/new-console-template for more information

using System.Xml;

// Console.WriteLine("Hello, World!");

// object height = 1.88; // хранение double в объекте
// object name = "Amir"; // хранение string в объекте
// Console.WriteLine($"{name} is {height} metres tall.");
// //int length1 = name.Length; // Выдаст ошибку компиляции!
// int length2 = ((string)name).Length; // сообщаем компилятору, что это строка
// Console.WriteLine($"{name} has {length2} characters.");


// хранение строки в объекте dynamic
// строка имеет свойство Length
//dynamic something = "Ahmed";
// int не имеет свойства Length
//dynamic something = 12;
// массив любого типа имеет свойство Length
//dynamic something = new[] { 3, 5, 7 };

// компилируется, но может вызвать исключение во время
// выполнения, если вы позже сохраните тип данных,
// у которого нет свойства Length
//Console.WriteLine($"Length is {something.Length}");


// int population = 66_000_000; // 66 миллионов человек в Великобритании
// double weight = 1.88; // в килограммах
// decimal price = 4.99M; // в фунтах стерлингов
// string fruit = "Apples"; // строки в двойных кавычках
// char letter = 'Z'; // символы в одиночных кавычках
// bool happy = true; // логическое значение — true или false

// var population = 66_000_000; // 66 миллионов человек в Великобритании
// var weight = 1.88; // в килограммах
// var price = 4.99M; // в фунтах стерлингов
// var fruit = "Apples"; // строки в двойных кавычках
// var letter = 'Z'; // символы в одиночных кавычках
// var happy = true; // логическое значение — true или false

// Console.WriteLine($"default(int) = {default(int)}");
// Console.WriteLine($"default(bool) = {default(bool)}");
// Console.WriteLine($"default(DateTime) = {default(DateTime)}");
// Console.WriteLine($"default(string) = {default(string)}");

// int number = 13;
// Console.WriteLine($"number has been set to: {number}");
// number = default;
// Console.WriteLine($"number has been reset to its default: {number}");

string[] names; // может ссылаться на любой по размеру массив строк
// выделение памяти для четырех строк в массиве
names = new string[4];
// хранение элементов с индексами позиций
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
// перебор имен
for (int i = 0; i < names.Length; i++)
{
 // вывести элемент в позиции индекса i
 Console.WriteLine(names[i]);
}

string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };

for (int i = 0; i < names2.Length; i++)
{
 // вывести элемент в позиции индекса i
 Console.WriteLine(names2[i]);
}