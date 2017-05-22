using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication21.Models
{
    public class JIACADEMY:DbContext
    {

        public DbSet<employees> employees { get; set; }

    }
}