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
![ER Diyagramı](https://gist.github.com/user-attachments/assets/8bf18533-65de-4fd8-be69-8521b3b82585)

---

## 💻 Arayüz Görselleri

### 🔑 Kullanıcı İşlemleri
- **Giriş Ekranı**  
  ![LoginForm](https://gist.github.com/user-attachments/assets/0bd07418-6b97-414a-8650-e127fc53dee8)

- **Kayıt Ekranı**  
  ![RegisterForm](https://gist.github.com/user-attachments/assets/0d04a99f-3508-464e-aef5-a290909ca9db)

- **Müşteri Paneli**  
  ![MusteriForm](https://gist.github.com/user-attachments/assets/de2fff57-e077-43c8-94f5-4481d7650177)

- **Kiralayan Paneli**  
  ![KiralayanForm](https://gist.github.com/user-attachments/assets/dffa043a-b51b-4af6-a18b-6d235814846b)

---

### 🚘 Araç İşlemleri
- **Araçlar Listesi**  
  ![Araclar](https://gist.github.com/user-attachments/assets/f1ce8501-4316-4119-aef6-545d1d975bf7)

- **Araç Ekleme**  
  ![Araç Ekleme](https://gist.github.com/user-attachments/assets/57058868-0e21-4079-9f12-2b4793c7ddfc)

- **Kiralanmış Araçlar**  
  ![Kiralanmis](https://gist.github.com/user-attachments/assets/2874b1db-39d0-44a4-84f3-d2c95cab623a)

- **Kiralanmamış Araçlar**  
  ![Kiralanmamis](https://gist.github.com/user-attachments/assets/ad843bac-a651-46b6-a169-789698723fba)

---

### 📑 Diğer Modüller
- **Faturalar**  
  ![Faturalar](https://gist.github.com/user-attachments/assets/6003cf77-5184-448a-bb9d-8e2aa0efe0bf)

- **İndirimler**  
  ![indirim](https://gist.github.com/user-attachments/assets/0246236d-6074-4e6f-9d29-c9bc8e3d6540)

- **Yorumlar**  
  ![yorumlar](https://gist.github.com/user-attachments/assets/e65963aa-458e-43a0-b71d-423030417362)

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
