﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AppContext:DbContext
    {
        public DbSet<Actividad> Actividades { get; set; }
    }
}
