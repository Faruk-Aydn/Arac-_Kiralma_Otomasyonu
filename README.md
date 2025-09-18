# 🚗 Araç Kiralama Otomasyonu

## 📌 Proje Açıklaması
Bu proje, **araç kiralama işlemlerini dijital bir platformda kolaylaştırmak** amacıyla geliştirilmiştir.  
Kullanıcılar sisteme giriş yaparak:  
- Araç rezervasyonu yapabilir,  
- Ödeme işlemlerini tamamlayabilir,  
- Araç kiralama geçmişine erişebilir.  

**Amaç:** Araç kiralama süreçlerini **hızlı, güvenilir ve kullanıcı dostu** bir şekilde sunmak ve tüm süreci **otomatikleştirmektir**.

---

## 🛠 Kullanılan Teknolojiler
- **Programlama Dili:** C#  
- **Veritabanı Yönetim Sistemi:** Microsoft SQL Server  
- **Geliştirme Ortamı:** Visual Studio  
- **Arayüz:** Windows Forms + DevExpress  
- **ORM:** Entity Framework 6.0  

---

## 🏗 Proje Mimarisi
Proje **katmanlı mimari** ile geliştirilmiştir:  

- **Sunum Katmanı (UI):** Windows Forms + DevExpress  
- **İş Mantığı Katmanı (BLL):** `AracService`, `KiralamaService`, `KullaniciService` vb. servisler  
- **Veri Erişim Katmanı (DAL):** `AracKiralamaContext` + Entity Framework  

### 📋 Class Diyagramı
![Class Diagram](./images/class.png)

### 🗄️ Veritabanı (ER Diyagramı)
![ER Diyagramı](./images/erdiagram.png)

---

## 💻 Arayüz Görselleri

### 🔑 Kullanıcı İşlemleri
- **Giriş Ekranı**  
  ![LoginForm](./images/login.png)

- **Kayıt Ekranı**  
  ![RegisterForm](./images/register.png)

- **Müşteri Paneli**  
  ![MusteriForm](./images/müşteri.png)

- **Kiralayan Paneli**  
  ![KiralayanForm](./images/kiralayan.png)

---

### 🚘 Araç İşlemleri
- **Araçlar Listesi**  
  ![Araclar](./images/araçlar.png)

- **Araç Ekleme**  
  ![Araç Ekleme](./images/araçekleme.png)

- **Kiralanmış Araçlar**  
  ![Kiralanmis](./images/kiralanmış.png)

- **Kiralanmamış Araçlar**  
  ![Kiralanmamis](./images/kiralanmamış.png)

---

### 📑 Diğer Modüller
- **Faturalar**  
  ![Faturalar](./images/fatura.png)

- **İndirimler**  
  ![indirim](indirim)

- **Yorumlar**  
  ![yorumlar](./images/yorum.png)

---

## ⚙️ Kurulum
1. Projeyi indirin veya klonlayın.  
2. Visual Studio üzerinde projeyi açın.  
3. MsSQL üzerinde **Entity Framework Code-First** ile veritabanını oluşturun.  
4. Gerekli **NuGet paketlerini yükleyin**.  
5. `.sln` dosyasını çalıştırarak projeyi başlatın.  

---

## 👨‍💻 Geliştirici
**Faruk AYDIN**
