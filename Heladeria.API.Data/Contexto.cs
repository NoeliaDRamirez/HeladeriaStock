using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.API.Data
{
    public partial class HeladeriaEntidadesContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-1G6DJMM\\SQLEXPRESS;initial catalog=Heladeria;integrated security=True;MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
