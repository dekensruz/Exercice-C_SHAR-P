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

string firstName;
firstName = "Dekens";
Console.WriteLine(firstName);
string lastName;
lastName = "Ruzuba";
Console.Write(firstName);
Console.WriteLine(lastName);

var message = "Hello World";

Console.WriteLine(message);


// Exercice
string nom = "Bob";
int nbreMessages = 3;
decimal temperature = 34.40m;

Console.WriteLine("Salut, " + nom + "! " + "vous avez " + nbreMessages +  " messages dans votre boîte de réception. " + "La température est de " + temperature + " dégré celcius" );