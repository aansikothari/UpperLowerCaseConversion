// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
char ch,chr;
ch = Console.ReadKey().KeyChar;

if (ch >= 'A' && ch <= 'Z')
    Console.WriteLine("\n" + Convert.ToChar(ch + 32));
else if (ch >= 'a' && ch <= 'z')
    Console.WriteLine("\n" + Convert.ToChar(ch - 32));
else
    Console.WriteLine("\nInvalid Input");

chr = 'l';

if (chr >= 'A' && chr <= 'Z')
    Console.WriteLine("\n" + Convert.ToChar(chr + 32));
else if (chr >= 'a' && chr <= 'z')
    Console.WriteLine("\n" + Convert.ToChar(chr - 32));
else
    Console.WriteLine("\nInvalid Input");
