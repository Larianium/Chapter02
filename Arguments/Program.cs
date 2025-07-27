// See https://aka.ms/new-console-template for more information
using static System.Console;
//WriteLine("Hello, World!");


// WriteLine($"There are {args.Length} arguments.");

// foreach (string arg in args)
// {
//  WriteLine(arg);
// }


// if (args.Length < 3)
// {
//  WriteLine("You must specify two colors and cursor size, e.g.");
//  WriteLine("dotnet run red yellow 50");
//  return; // прекращение запуска
// }

// ForegroundColor = (ConsoleColor)Enum.Parse(
//  enumType: typeof(ConsoleColor),
//  value: args[0],
//  ignoreCase: true);

// BackgroundColor = (ConsoleColor)Enum.Parse(
//  enumType: typeof(ConsoleColor),
//  value: args[1],
//  ignoreCase: true);

// try
// {
//     CursorSize = int.Parse(args[2]);
// }
// catch (PlatformNotSupportedException)
// {
//     WriteLine("The current platform does not support changing the size of the cursor.");
// }

if (OperatingSystem.IsWindows())
{
 // выполнить код, работающий только в Windows
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
 // выполнить код, работающий только в Windows 10 или более поздней версии
}
else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
{
 // выполнить код, работающий только в iOS 14.5 или более поздней версии
}
else if (OperatingSystem.IsBrowser())
{
 // выполнить код, работающий только в браузере с Blazor
}

ReadLine();


