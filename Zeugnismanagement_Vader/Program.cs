// See https://aka.ms/new-console-template for more information

using System;
using System.Security.AccessControl;

int[] Note = new int[8];
string Name;
string[] Fächernamen = new string[8];
int Fehl;
int enFehl;
int unFehl;
string Datum;
int Unterkurs = 0;
int Versetzung = 0;
bool prüfen = false;


Console.WriteLine("Zeugnismanagement-Software");
do
{
    Console.WriteLine("dd.MM.yyyy:  ");
    Datum = Console.ReadLine();

    if(int.TryParse(Datum, out _))
    {

        prüfen = true;

    }
    else
    {

        Console.WriteLine("Eingabe ist falsch");

    }
}

while (prüfen == false);

prüfen = false;

Console.WriteLine("Name des Schülers:  ");
Name = Console.ReadLine();

Console.WriteLine("Geben Sie Fehltage ein: ");
Fehl = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Geben Sie entschuldigte Fehltage ein: ");
enFehl = Convert.ToInt32(Console.ReadLine());

unFehl = Fehl - enFehl;


for (int i = 0; i < Note.Length; i++)
{

   
    



        Console.WriteLine("Name des Faches Nr." + i);
        Fächernamen[i] = Console.ReadLine();


    
    
    do
    {
        string input;
        Console.WriteLine("Note des Faches " + Fächernamen[i]);

        input = Convert.ToString(Console.ReadLine());

        if (int.TryParse(input, out Note[i]))
        {

            prüfen = false;
            

        }
        else
        {

            Console.WriteLine("Eingabe ist falsch");

        }

    }

    while (prüfen == true);
    if (Note[i] < 5)
    {
        Unterkurs += 1;
    }


}

double insgesamt = 0;

for (int x = 0; x < 8; x++)
{

    if (Note[x] <= 15 && Note[x] >= 0)
    {

        insgesamt = insgesamt + Note[x];


    }

    else
    {

        Console.WriteLine("Fehler bei " + Fächernamen[x]);

    }


}

insgesamt = insgesamt + Note[0] + Note[1];
insgesamt = insgesamt / 10;

//* Ausgabe *//

Console.WriteLine("Der Durchschnitt mit doppelter Gewichtung ist: " + insgesamt);

if(Unterkurs >= 2 )
{
    Console.WriteLine("mehr als 1 Unterkurs");
}

if(unFehl > 30)
{
    Console.WriteLine("zu viel Fehltage");


}

Console.WriteLine("Taste drücken um Zeugnis zu Erstellen");
Console.ReadKey(true);
Console.WriteLine("-----Zeugnis-----");
Console.WriteLine("Datum: " + Datum);
Console.WriteLine("Name: " + Name);
Console.WriteLine("-----------------");
for (int i = 0; i < Note.Length; i++)
{
    
    Console.WriteLine(Fächernamen[i] + ":  " + Note[i]);

    
}

Console.WriteLine("Fehltage: " + Fehl);
Console.WriteLine("davon unentschuldigt: " + unFehl);

if (unFehl> 30)
{
    Versetzung += 1;
}
if (Unterkurs > 1)
{
    Versetzung += 1;
}
if (Versetzung > 0)
{
    
        Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Der Schüler wird nicht versetzt");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Der Schüler wird versetzt.");
}
Console.ForegroundColor = ConsoleColor.White;
