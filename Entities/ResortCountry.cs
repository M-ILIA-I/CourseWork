﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    [Table ("ResortCountries")]
    public class ResortCountry : Country
    {
        public int Id { get; set; }
    }
}
