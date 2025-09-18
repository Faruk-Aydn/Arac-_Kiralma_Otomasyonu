Araç Kiralama Otomasyonu
Proje Açıklaması
Bu proje, araç kiralama işlemlerini dijital bir platformda kolaylaştırmak amacıyla tasarlanmıştır. Kullanıcılar sisteme giriş yaparak araç rezervasyonu yapabilir, ödeme işlemlerini tamamlayabilir ve araç kiralama geçmişine erişebilirler. Projenin amacı, araç kiralama süreçlerini hızlı, güvenilir ve kullanıcı dostu bir şekilde sunmak ve otomasyonu sağlamaktır.

Kullanılan Teknolojiler
Programlama Dili: C#

Veritabanı Yönetim Sistemi: MsSQL

Geliştirme Ortamı: Visual Studio

Arayüz Tasarımı: Devexpress ve Windows Forms

Veritabanı Erişimi: Entity Framework 6.0

Proje Mimarisi ve Diyagramlar
Proje, katmanlı bir mimariye sahiptir.

Sunum Katmanı (UI): Windows Forms ve DevExpress kontrolleri kullanılarak tasarlanmıştır.

İş Mantığı Katmanı (BLL): AracService, KiralamaService ve KullaniciService gibi servisleri içerir.

Veri Erişim Katmanı (DAL): AracKiralamaContext ve Entity Framework ile veritabanı işlemlerini yönetir.

![Class Diagram](https://gist.github.com/user-attachments/assets/2ed4d225-784c-4041-b923-db1b45917588)
![Veritabanı Tasarımı (ER Diyagramı)](https://gist.github.com/user-attachments/assets/8bf18533-65de-4fd8-be69-8521b3b82585)

Arayüz Görselleri
Projenin kullanıcı arayüzüne ait bazı ekran görüntüleri aşağıda yer almaktadır.

Kullanıcı İşlemleri
Giriş Arayüzü:
![LoginForm](https://gist.github.com/user-attachments/assets/0bd07418-6b97-414a-8650-e127fc53dee8)

Kayıt Arayüzü:
![RegisterForm](https://gist.github.com/user-attachments/assets/0d04a99f-3508-464e-aef5-a290909ca9db)

Müşteri Arayüzü:
![MusteriForm](https://gist.github.com/user-attachments/assets/de2fff57-e077-43c8-94f5-4481d7650177)

Kiralayan Arayüzü:
![KiralayanForm](https://gist.github.com/user-attachments/assets/dffa043a-b51b-4af6-a18b-6d235814846b)

Diğer Arayüzler
Araçlar Kontrolü:
![Araclar](https://gist.github.com/user-attachments/assets/f1ce8501-4316-4119-aef6-545d1d975bf7)

Araç Ekleme Arayüzü:
[Araç Ekleme](https://gist.github.com/user-attachments/assets/57058868-0e21-4079-9f12-2b4793c7ddfc)

Kiralanmış Araçlar:
![Kiralanmis](https://gist.github.com/user-attachments/assets/2874b1db-39d0-44a4-84f3-d2c95cab623a)
Kiralanmamış Araçlar:
![Kiralanmamiş](https://gist.github.com/user-attachments/assets/ad843bac-a651-46b6-a169-789698723fba)

Faturalar Arayüzü:
![Faturalar](https://gist.github.com/user-attachments/assets/6003cf77-5184-448a-bb9d-8e2aa0efe0bf)

İndirimler Arayüzü:
![indirim](https://gist.github.com/user-attachments/assets/0246236d-6074-4e6f-9d29-c9bc8e3d6540).

Yorumlar Arayüzü:
![yorumlar](https://gist.github.com/user-attachments/assets/e65963aa-458e-43a0-b71d-423030417362).

Kurulum
Projenin kaynak kodunu indirin veya klonlayın.

Visual Studio'yu açın ve projeyi yükleyin.

MsSQL veritabanınızı Entity Framework Code-First yaklaşımı ile oluşturun.

Gerekli NuGet paketlerini yükleyin.

Proje klasöründeki .sln dosyasını kullanarak çözümü çalıştırın.

Proje Geliştiricisi
Faruk AYDIN
