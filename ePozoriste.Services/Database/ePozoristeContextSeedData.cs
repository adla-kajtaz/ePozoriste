using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.Services.Database
{
    partial class ePozoristeContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>().HasData(new Drzava[]
             {
                new Drzava()
                {
                    DrzavaId = 1,
                    Naziv = "Bosna i Hercegovina",
                    Skracenica = "BiH"
                },
                new Drzava()
                {
                    DrzavaId = 2,
                    Naziv = "Hrvatska",
                    Skracenica = "HR"
                }
            });
        }
       
    }
}
