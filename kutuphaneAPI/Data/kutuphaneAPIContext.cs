using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kutuphaneAPI.Class;

    public class kutuphaneAPIContext : DbContext
    {
        public kutuphaneAPIContext (DbContextOptions<kutuphaneAPIContext> options)
            : base(options)
        {
        }

        public DbSet<kutuphaneAPI.Class.Kitap> Kitap { get; set; } = default!;


    }
