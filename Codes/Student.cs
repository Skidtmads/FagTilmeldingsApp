using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingsApp.Codes
{
    internal class Student
    {


        public int ElevId { get; set; }
        public string? ForNavn { get; set; }
        public string? EfterNavn { get; set; }
        public int TelefonNr { get; set; }

    }
    internal class ElevListe
    {
        public object[,] H1Hold { get; set; }
        public record Output(object Ob1, object Ob2);

        public DateTime StartKvartal { get; set; }

        public DateTime SlutKvartal { get; set; }
        public ElevListe()
        {

            string fag;
            string lærer;
            Student Elev1 = new Student();
            Student Elev2 = new Student();
            Student Elev3 = new Student();
            Student Elev4 = new Student();

            List<Student> GPelever = new List<Student>()
            {
                Elev3,
                Elev1
            };
            List<Student> DBelever = new List<Student>()
            {
                Elev1,
                Elev2
            };
            List<Student> STelever = new List<Student>()
            {
                Elev1,
                Elev4,
                Elev3
            };

            Elev1.ElevId = 1;
            Elev1.ForNavn = "Martin";
            Elev1.EfterNavn = "Jensen";
            Elev1.TelefonNr = 12345678;

            Elev2.ElevId = 2;
            Elev2.ForNavn = "Jan";
            Elev2.EfterNavn = "Larsen";
            Elev2.TelefonNr = 12345678;

            Elev3.ElevId = 3;
            Elev3.ForNavn = "Tobias";
            Elev3.EfterNavn = "Pedersen";
            Elev3.TelefonNr = 12345678;

            Elev4.ElevId = 4;
            Elev4.ForNavn = "Morten";
            Elev4.EfterNavn = "Nielsen";
            Elev4.TelefonNr = 12345678;



            H1Hold = new object[,]
            {
                { fag = "Grundlæggende Programmering", lærer = "Niels", GPelever },
                { fag = "Database Programmering", lærer = "Henrik", DBelever },
                { fag = "Studieteknik", lærer = "John", STelever }
            };
        }
    }
}

