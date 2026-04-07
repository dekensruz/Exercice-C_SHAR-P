// // AFFICHER UN MESSAGE

// Console.WriteLine("Hello world");
// Console.Write("This is the first line");
// Console.WriteLine("This is the second line");
// Console.WriteLine('d');
// Console.WriteLine(123);
// Console.WriteLine(0.25F);
// Console.WriteLine(2.625);
// Console.WriteLine(12.39816m);
// Console.WriteLine(true);
// Console.WriteLine(false);


// // Output: 123
// Console.WriteLine("123");
// // Output: 123
// Console.WriteLine(123);

// // Output: true
// Console.WriteLine("true");
// // Output: True
// Console.WriteLine(true);


// // DECLARATION DES VARIABLES

// string firstName;
// int age;
// decimal taille;
// bool estEtudiant;

// LES VARIABLES

using System.Runtime.CompilerServices;

// string firstName;
// firstName = "Dekens";
// Console.WriteLine(firstName);
// string lastName;
// lastName = "Ruzuba";
// Console.Write(firstName);
// Console.WriteLine(lastName);

// var message = "Hello World";

// Console.WriteLine(message);


// // Exercice
// string nom = "Bob";
// int nbreMessages = 3;
// decimal temperature = 34.40m;

// Console.WriteLine("Salut, " + nom + "! " + "vous avez " + nbreMessages +  " messages dans votre boîte de réception. " + "La température est de " + temperature + " dégré celcius" );

//COMBINER LES CHAINES DE CARACTERES
// Console.WriteLine("Hello\nWorld");
// Console.WriteLine("Hello\tWorld");
// Console.WriteLine("Hello \"World\"!");
// Console.WriteLine("\\");


// Console.WriteLine(@"Salut à toi \ ");


// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// Console.WriteLine("Generating invoices for customer \"Contos corp\" .... \n");
// Console.WriteLine("Invoice : 1021\t Complete");
// Console.WriteLine("Invoice : 1022\t Complete \n");
// Console.Write("\nOutpour directory:\t");
// Console.Write(@"c:\invoices");

// // To generate Japanese invoices:
// // Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");

//INTERPLOATION 

// string greeting = "Bonjour";
// string name = "Dekens";

// Console.WriteLine($"{greeting} {name}");

// string name = "Dekens";
// string message = $"Bonjour {name}";
// Console.WriteLine(message);

// int version = 11;
// string updateText = "update to windows";
// Console.WriteLine($"{updateText} {version}");

// string projectName= "IsigCommunity";
// Console.WriteLine(@$"C:\Projects\{projectName}\Data");

// string englishMessage = "View English outpout";
// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// string projectName = "ACME";
// string outpout =@$"c:\Exerices\{projectName}\data.txt";

// Console.WriteLine(englishMessage);
// Console.WriteLine(outpout + "\n");
// Console.WriteLine(russianMessage);
// Console.WriteLine(outpout);


// Console.WriteLine('directory = directory + @"\";');

// OPERATIONS

// int firstNumber = 10;
// int secondNumber = 11;

// Console.WriteLine(firstNumber + secondNumber);

// string firstName = "Dekens";
// int widgetSold = 7;
// Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
decimal decimalQuotient = 7m/5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine($"Quotient décimal : {decimalQuotient}");