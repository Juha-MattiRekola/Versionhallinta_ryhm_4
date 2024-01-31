// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Versionhallintatehtävän koodiosuus, muokattavaa tilaa on paljon!");

string henkilo1 = "Juha-Matti"; //tervehdykset
Console.WriteLine($"Hei {henkilo1}!");
string henkilo2 = "Niina";
Console.WriteLine($"Hei {henkilo2}!");

List<string> tiiminjasenet = []; //lista ryhmän jäsenistä
tiiminjasenet.Add("Juha-Matti"); //lisätään ryhmän jäsenet listaan
tiiminjasenet.Add("Niina");

Console.WriteLine("Tiimissä on yhteensä " + tiiminjasenet.Count + " jäsentä:"); //tiimin jäsenten määrä

for (int i = 0; i < tiiminjasenet.Count; i++) //nimien tulostaminen listasta
{
    Console.WriteLine(tiiminjasenet[i]);
}

if (tiiminjasenet.Count == 4)
{
    Console.WriteLine("Kaikki jäsenet ovat paikalla.");
}
else
{
    Console.WriteLine("Tiimin jäseniä puuttuu vielä.");
}

