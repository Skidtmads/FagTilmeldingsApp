﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingsApp.Codes
{
    internal class School
    {
        public string? SchoolName { get; set; }

        public School(string? schoolName = "TEC")
        {
            SchoolName = schoolName;
        }
    }
}
