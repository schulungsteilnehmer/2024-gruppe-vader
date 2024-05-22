// See https://aka.ms/new-console-template for more information


int[] Note = new int[8];
string Name;
string[] Fächernamen = new string[8];

Console.WriteLine("Zeugnismanagement-Software");
Console.WriteLine("Name des Schülers:  ");

Name = Console.ReadLine();

for (int i = 0; i < Note.Length; i++)
{

    Console.WriteLine("Name des Faches Nr." + i);
    Fächernamen[i] = Console.ReadLine();

    Console.WriteLine("Note des Faches " + Fächernamen[i]);
    Note[i] = Convert.ToInt32(Console.ReadLine());



}

double insgesamt = 0;

for(int x = 0; x < 8; x++)
{

    insgesamt = insgesamt + Note[x];


}

insgesamt = insgesamt + Note[0] + Note[1];
insgesamt = insgesamt / 10;

Console.WriteLine("Der Durchschnitt mit doppelter Gewichtung")
Console.WriteLine(insgesamt);

Console.WriteLine("Taste drücken um neues Zeugnis zu Erstellen");
Console.ReadKey(true);





