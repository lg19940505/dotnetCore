using Microsoft.EntityFrameworkCore;
using notCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notCoreMVC.Data
{
    public class MvcMovieContext:DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options):base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}
