using kutuphaneAPI.Class;
using kutuphaneRezervasyon.Areas.Identity.Data;
using kutuphaneRezervasyon.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace kutuphaneRezervasyon.Areas.Identity.Data;

public class KutuphaneContext : IdentityDbContext<Kullanici>
{
    public DbSet<Kitap> Kitap { get; set; } = default!;
    public DbSet<Rezerve> Rezerveler { get; set; } = default!;
    public DbSet<Rezervasyon> Rezervasyonlar { get; set; } = default!;

    public KutuphaneContext(DbContextOptions<KutuphaneContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Konvansiyon RezervasyonId'yi PK olarak algılar, yine de garanti için ekledim
        builder.Entity<Rezerve>().HasKey(r => r.RezervasyonId);
        builder.Entity<Rezervasyon>().HasKey(r => r.RezervasyonId);
    }
}