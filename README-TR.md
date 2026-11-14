<a href="README.md">
  <img src="https://img.shields.io/badge/Language-English-blue?style=flat-square&logo=google-translate&logoColor=white" alt="English">
</a>
<a href="README-TR.md">
  <img src="https://img.shields.io/badge/Language-Türkçe-red?style=flat-square&logo=google-translate&logoColor=white" alt="Türkçe">
</a>

  <br />
  <br />

<div align="center">
  <img src="mascot.png" width="120" height="120" />
  <br />
  <br />

  <p>
     C# WinForms ve MySQL ile hazırlanmış basit bir stok takip uygulaması.
  </p>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)

  <p>
    <a href="#about">Hakkında</a> •
    <a href="#features">Özellikler</a> •
    <a href="#tech">Teknolojiler</a> •
    <a href="#setup">Kurulum</a> •
    <a href="#gallery">Galeri</a> •
    <a href="#license">Lisans</a>
  </p>

  <br />
  <br />
</div>

## <a id="about"></a> 📋 Hakkında

Bu proje, lise yıllarımda C# WinForms ve MySQL kullanarak hazırladığım bir dönem ödevi. İçeriği oldukça basit ve anlaşılır tutmaya çalışmıştım. Temel olarak; ürün ekleme, silme, güncelleme gibi stok takip işlemlerini yapabiliyorsunuz. Ayrıca hem kullanıcı hem de yönetici girişi gibi özellikleri de mevcut. Eski ama hatırası olan bir çalışma olduğu için burada paylaşıyorum.

Uygulamanın iki tarafı vardır. Yetkililer ürünleri yönetir, müşterileri ve siparişleri görüntüler. Müşteriler ise kayıt olur, ürünlere göz atar ve sipariş verir. Verilen her sipariş, ürünün veritabanındaki stoğunu düşürür.

## <a id="features"></a> ✨ Özellikler

- **Yetkili paneli**: Ürün ekleyin, güncelleyin ve silin, bir ürünü ID'siyle bulun, ürün, müşteri ve sipariş listelerini toplam sayılarıyla birlikte görüntüleyin.
- **Müşteri kaydı**: Kişisel bilgilerinizle kayıt olun. Uygulama, kullanıcı adının boşta olduğunu, şifrenin en az 8 karakter olduğunu ve doğum tarihinin geçerli olduğunu kontrol eder.
- **Ürün arama**: Ürünleri adına göre arayın, fiyatlarını ve stoklarını görün.
- **Sipariş verme**: Ürünü ID'siyle seçin, adedi girin ve teslimat adresini onaylayın. Adresinizi tek tıkla hesabınızdan doldurabilirsiniz.
- **Stok kontrolü**: Stoğu tükenmiş ürünler ve mevcut stoktan fazla adetler için sipariş verilemez.
- **Hesap ve siparişler**: Hesap bilgilerinizi ve geçmiş siparişlerinizi görüntüleyin.

## <a id="tech"></a> 🛠️ Teknolojiler

`C#` · `.NET Framework` · `Windows Forms` · `MySQL` · `MySql.Data`

## <a id="setup"></a> 🚀 Kurulum

### Gereksinimler

- **Windows**
- **Visual Studio**
- **.NET Framework 4.7.2**
- **MySQL**

### Adım Adım Kurulum

1. **Depoyu klonlayın**

   ```bash
   git clone https://github.com/xkintaro/stock-app.git
   cd stock-app
   ```

2. **Veritabanını kurun**

   MySQL'de `stockapp` adında bir veritabanı oluşturun ve `stockapp.sql` dosyasını bu veritabanına içe aktarın.

   Uygulama varsayılan olarak `root` kullanıcısı ve boş şifreyle bağlanır. MySQL ayarlarınız farklıysa `stockApp/App.config` dosyasındaki bağlantı bilgisini güncelleyin.

3. **Projeyi açın**

   `stockApp.sln` dosyasını Visual Studio ile açın. NuGet paketleri, projeyi derlediğinizde otomatik olarak yüklenir.

4. **Uygulamayı çalıştırın**

   Uygulamayı derleyip başlatmak için `F5` tuşuna basın. Yetkili paneline `admin` kullanıcı adı ve `123` şifresiyle giriş yapabilirsiniz.

## <a id="gallery"></a> 🖼️ Galeri

<img src="md/20260403140402918.jpg" width="100%" />

<img src="md/20260403140402978.jpg" width="100%" />

<img src="md/20260403140403038.jpg" width="100%" />

<img src="md/20260403140403103.jpg" width="100%" />

<img src="md/20260403140403171.jpg" width="100%" />

<img src="md/20260403140403237.jpg" width="100%" />

## <a id="license"></a> 📄 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakabilirsiniz.

#

<p align="center">
  <sub>❤️ Developed by "Mustafa TAŞAL" (kintaro)</sub>
</p>
