using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingsApp.Codes
{
    internal class Teacher
    { 
        
        public string? ForNavn { get; set; }
        public string? EfterNavn { get; set; }
        public string?  LærerId { get; set; }
        
        List<Teacher> lærer = new()
        {
            new Teacher() { ForNavn = "Niels", EfterNavn = "Olesen" },
            new Teacher() { ForNavn = "Henrik", EfterNavn = "Poulsen" }
        };
    }
}
