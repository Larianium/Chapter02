// See https://aka.ms/new-console-template for more information
using System.Reflection;

// объявление некоторых неиспользуемых переменных
// с помощью типов в дополнительных сборках
System.Data.DataSet ds;
HttpClient client;

//#error version
//Console.WriteLine("Hello, World!");

// Assembly? assembly = Assembly.GetEntryAssembly();
// if (assembly == null) return;
// // перебор сборок, на которые ссылается приложение
// foreach (AssemblyName name in assembly.GetReferencedAssemblies())
// {
//     // загрузка сборки для чтения данных
//     Assembly a = Assembly.Load(name);

//  // объявление переменной для подсчета количества методов
//  int methodCount = 0;
//     // перебор всех типов в сборке
//     foreach (TypeInfo t in a.DefinedTypes)
//     {
//         // добавление количества методов
//         methodCount += t.GetMethods().Count();
//     }
//     // вывод количества типов и их методов
//     Console.WriteLine(
//     "{0:N0} types with {1:N0} methods in {2} assembly.",
//     arg0: a.DefinedTypes.Count(),
//     arg1: methodCount, arg2: name.Name);
// }

// присвоение переменной heightInMetres значения, равного 1.88
double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
