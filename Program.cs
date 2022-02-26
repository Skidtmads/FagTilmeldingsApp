using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FagTilmeldingsApp.Codes;


string SkoleInput, HovedforløbInput;
Console.WriteLine("Angiv skolens navn: ");
SkoleInput = Console.ReadLine();
Console.WriteLine("Angiv hovedforløbets navn: ");
HovedforløbInput = Console.ReadLine();
Console.Clear();


Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
Console.WriteLine("{0}, {1} - Fag tilmeldings app.", SkoleInput, HovedforløbInput);
Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");



List<Student> ElevListe = new()
{
    new Student() { ElevId = 1, ForNavn = "Martin", EfterNavn = "Jensen" },
    new Student() { ElevId = 2, ForNavn = "Patrik", EfterNavn = "Nielsen" },
    new Student() { ElevId = 3, ForNavn = "Susanne", EfterNavn = "Hansen" },
    new Student() { ElevId = 4, ForNavn = "Thomas", EfterNavn = "Olsen" }

};

List<Hold> = Fag = new()
{
    new Hold() {Fag = "Grundlæggende Programmering", lærer = "Niels", GPelever, ugeNr = new int[] {3 , 4} },
    new Hold() {fag = "Database Programmering", lærer = "Henrik", DBelever, ugeNr = new int[] {5} },
    new Hold() {fag = "Studieteknik", lærer = "John", STelever, ugeNr = new int[] {6} }
};



