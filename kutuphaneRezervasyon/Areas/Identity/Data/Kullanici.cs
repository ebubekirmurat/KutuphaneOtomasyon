using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using kutuphaneRezervasyon.Entities;

namespace kutuphaneRezervasyon.Areas.Identity.Data;

public class Kullanici : IdentityUser
{
    public virtual ICollection<Rezervasyon> Rezervasyonlar { get; set; } = new List<Rezervasyon>();
    public virtual ICollection<Rezerve> Rezerveler { get; set; } = new List<Rezerve>();
}