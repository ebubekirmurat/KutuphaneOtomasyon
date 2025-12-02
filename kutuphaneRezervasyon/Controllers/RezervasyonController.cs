using kutuphaneAPI.Class;
using kutuphaneRezervasyon.Areas.Identity.Data;
using kutuphaneRezervasyon.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kutuphaneRezervasyon.Controllers
{
    [Authorize]
    public class RezervasyonController : Controller
    {
        private readonly KutuphaneContext _context;
        private readonly UserManager<Kullanici> _userManager;
        private readonly IHttpClientFactory _factory;

        public RezervasyonController(IHttpClientFactory factory,
            KutuphaneContext context, UserManager<Kullanici> userManager)
        {
            _context = context;
            _userManager = userManager;
            _factory = factory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _factory.CreateClient();
            // API'nin ana adresi
            client.BaseAddress = new Uri("https://localhost:7208/");

            // 1) Kitabı al
            var tumKitaplar = await client.GetFromJsonAsync<List<Kitap>>($"/api/Kitap");

            return View(tumKitaplar);
        }

        public async Task<IActionResult> RezervasyonYap(int id)
        {
            var client = _factory.CreateClient();

            // API'nin ana adresi
            client.BaseAddress = new Uri("https://localhost:7208/");



            // 1) Kitabı al
            var secilenKitap = await client.GetFromJsonAsync<Kitap>($"api/Kitap/{id}");

            if (secilenKitap == null)
                return NotFound();

            //kullanıcının id'sini al
            var anlikKullaniciIdsi = _userManager.GetUserId(HttpContext.User);


            // 2) Rezervasyonu oluştur
            var rezervasyon = new Rezervasyon
            {
                KitapAdi = $"{secilenKitap.KitapId}:{secilenKitap.KitapAdi}",
                KullaniciId = anlikKullaniciIdsi,
                BasimYili = secilenKitap.BasimYili,
                Yayinevi = secilenKitap.Yayinevi,
                YazarAdi = secilenKitap.YazarAdi

            };

            await _context.Rezervasyonlar.AddAsync(rezervasyon);
            await _context.SaveChangesAsync();

            // 3) Kitap durumunu API üzerinden güncelle
            await client.PutAsJsonAsync($"api/Kitap/{id}", secilenKitap);
            TempData["Mesaj"] = "Rezervasyon başarıyla Yapıldı";

            return RedirectToAction("Rezervasyonlar");

        }

        public async Task<IActionResult> Rezervasyonlar()
        {
            var anlikKullaniciIdsi = _userManager.GetUserId(HttpContext.User);
            return View(await _context.Rezervasyonlar.Where(r => r.KullaniciId == anlikKullaniciIdsi).ToListAsync());

        }

        public async Task<IActionResult> RezervasyonuIptalEt(int id)
        {
            var secilenRezervasyon = await _context.Rezervasyonlar.FindAsync(id);

          
            if (secilenRezervasyon == null)
                return NotFound();

            return View(secilenRezervasyon);
        }


        // POST: RezervasyonuIptalEt
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RezervasyonuIptalEt(Rezervasyon rezervasyon)
        {
            
        
         
            // Veritabanından rezervasyonu sil
            _context.Rezervasyonlar.Remove(rezervasyon);
            await _context.SaveChangesAsync();

            return RedirectToAction("Rezervasyonlar");
        }

    }
}




