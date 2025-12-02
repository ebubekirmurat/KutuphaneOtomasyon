📚 Kütüphane Rezervasyon Sistemi (MVC + API + Code First)

Bu proje, ASP.NET Core MVC ve Web API tabanlı bir kütüphane rezervasyon sistemidir. Entity Framework Core Code First yaklaşımı ile veritabanı modelleri doğrudan koddan oluşturulur ve yönetilir.

✨ Özellikler
Kullanıcılar için

🔍 Kitap arama ve filtreleme

📖 Kitap detaylarını görüntüleme

📝 Rezervasyon yapma ve iptal etme

➕ Kitap ekleme, düzenleme ve silme

📊 Rezervasyonları görüntüleme ve yönetme

🛠 Teknolojiler
| Katman      | Teknoloji                                |
|------------|------------------------------------------|
| Backend    | ASP.NET Core MVC, Web API                 |
| ORM        | Entity Framework Core (Code First)        |
| Frontend   | Razor Pages / Bootstrap / JS              |
| Veritabanı | SQL Server                                |
| Diğer      | JWT Authentication, Swagger API Dokumentasyonu |

🚀 Kurulum

Projeyi klonlayın:

git clone https://github.com/kullanici/kutuphane-rezervasyon.git
cd kutuphane-rezervasyon


NuGet paketlerini yükleyin:

dotnet restore


Veritabanını Code First ile oluşturun:

dotnet ef database update


Sunucuyu başlatın:

dotnet run


Tarayıcıda açın:

https://localhost:5001


MVC: Kullanıcı arayüzü (Web sayfaları)

API: CRUD işlemleri ve rezervasyon işlemleri

Code First: Veritabanı tabloları DbContext ve model sınıflarından oluşturulur

🤝 Katkıda Bulunma

Projeyi fork’layın.

Yeni bir branch açın (git checkout -b ozellik-adi).

Değişikliklerinizi commit’leyin (git commit -m 'Yeni özellik eklendi').

Branch’i push’layın (git push origin ozellik-adi).

Pull request oluşturun.

📄 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için LICENSE
 dosyasına bakabilirsiniz