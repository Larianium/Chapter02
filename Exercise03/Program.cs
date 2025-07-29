// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Linq;
using static System.Console;

//Console.WriteLine("Hello, World!");

//Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
//Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
//Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

//string applesText = "Apples";
//int applesCount = 1234;
//string bananasText = "Bananas";
//int bananasCount = 56789;


//WriteLine(
// format: "{0,-10} {1,6} {2,12} {3,18}",
// arg0: "Name",
// arg1: "Count");


//WriteLine(
// format: "{0,-10} {1,6:N0}",
// arg0: applesText,
// arg1: applesCount);

//WriteLine(
// format: "{0,-10} {1,10:N0}",
// arg0: bananasText,
// arg1: bananasCount);



//string  sb = "sbyte",
//        by = "byte",
//        sh = "short",
//        ush = "ushort",
//        i = "int",
//        ui = "uint",
//        l = "long",
//        ul = "ulong",
//        fl = "float",
//        dob = "double",
//        dec = "decimal";

string format = "{0,-10} {1,18} {2,30} {3,30}";

WriteLine(format, "Type", "Byte(s) of memory", "Min", "Max");
WriteLine(format, "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine(format, "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine(format, "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine(format, "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine(format, "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine(format, "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine(format, "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine(format, "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
WriteLine(format, "float", sizeof(float), float.MinValue, float.MaxValue);
WriteLine(format, "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine(format, "decimal", sizeof(decimal), sbyte.MinValue, decimal.MaxValue);



//WriteLine($"{sb,-10} {sizeof(sbyte),6} {sbyte.MinValue,20} {sbyte.MaxValue,10}");
//WriteLine($"{by,-10} {sizeof(byte),6} {byte.MinValue,20} {byte.MaxValue,10}");
//WriteLine($"{sh,-10} {sizeof(short),6} {short.MinValue,20} {short.MaxValue,10}");
//WriteLine($"{ush,-10} {sizeof(ushort),6} {ushort.MinValue,20} {ushort.MaxValue,10}");
//WriteLine($"{i,-10} {sizeof(int),6} {int.MinValue,20} {int.MaxValue,10}");
//WriteLine($"{ui,-10} {sizeof(uint),6} {uint.MinValue,20} {uint.MaxValue,10}");
//WriteLine($"{l,-10} {sizeof(long),6} {long.MinValue,20} {long.MaxValue,10}");
//WriteLine($"{ul,-10} {sizeof(ulong),6} {ulong.MinValue,20} {ulong.MaxValue,10}");
//WriteLine($"{fl,-10} {sizeof(float),6} {float.MinValue,20} {float.MaxValue,10}");
//WriteLine($"{dob,-10} {sizeof(double),6} {double.MinValue,20} {double.MaxValue,10}");
//WriteLine($"{dec,-10} {sizeof(decimal),6} {decimal.MinValue,20} {decimal.MaxValue,10}");