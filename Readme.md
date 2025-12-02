📚 Kütüphane Rezervasyon Sistemi - README

1. Proje Hakkında
Kütüphane Rezervasyon Sistemi, kullanıcıların kitapları görüntüleyip rezervasyon yapabileceği bir web uygulamasıdır.  
API desteği sayesinde başka uygulamalar da kitap ve rezervasyon verilerine erişebilir.  

**Özellikler:**  
- Kitap ekleme, güncelleme, silme  
- Rezervasyon yapma ve iptal etme  
- API ile kitap ve rezervasyon CRUD  
- Modern tema ve animasyonlar  
- Responsive ve mobil uyumlu  

---

2. Teknolojiler
- ASP.NET Core MVC + Razor  
- REST API endpoints  
- Validation 
- Bootstrap 5, CSS Animations  

---

 3. API Endpoints

| Method | URL                       | Açıklama                   |
|--------|---------------------------|----------------------------|
| GET    | /api/Kitap                | Tüm kitapları listeler     |
| GET    | /api/Kitap/{id}           | Kitap detaylarını getirir |
| POST   | /api/Kitap                | Yeni kitap ekler           |
| PUT    | /api/Kitap/{id}           | Kitap günceller            |
| DELETE | /api/Kitap/{id}           | Kitap siler               |


4. Kullanım

1. Projeyi klonlayın:  
```bash
git clone <proje-url>
Bağımlılıkları yükleyin ve çalıştırın:

bash
Kodu kopyala
dotnet restore
dotnet run
Tarayıcıdan erişim:

arduino
Kodu kopyala
https://localhost:5001
API örnek çağrısı:

http
Kodu kopyala
GET https://localhost:5001/api/Kitap
5. Tasarım Özellikleri
Animasyonlu sayfalar ve modern butonlar

Hover efektli tablolar ve form alanları

Renk paleti: Lacivert / Mavi / Beyaz

6. İleriye Dönük Geliştirmeler
Kullanıcı yönetimi ve yetkilendirme

Rezervasyon takvimi ve bildirim sistemi
