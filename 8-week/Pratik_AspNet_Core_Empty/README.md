## Türkçe Açıklama

Bu proje, ASP.NET Core MVC mimarisinin temel yapılarını gösteren bir pratik uygulamadır.

### Temel Bileşenler

1. **Controller (Denetleyici)**
   - HTTP isteklerini işleyen sınıflardır
   - İstekleri işleyip yanıt döndüren action metotlarını içerir
   - Model ve View arasındaki koordinasyonu sağlar
   Örnek: HomeController'daki Index ve About action'ları

2. **Model (Veri Modeli)**
   - Veriyi ve iş mantığını temsil eder
   - Veri yapısını tanımlayan düz C# sınıflarıdır
   - Doğrulama ve iş kurallarını içerebilir
   Örnek: TestViewModel sınıfı

3. **View (Görünüm)**
   - HTML oluşturmak için kullanılan şablonlardır
   - Views klasöründe, controller'a göre düzenlenir
   - Razor sözdizimini kullanarak dinamik içerik oluşturur
   Örnek: About.cshtml ve Index.cshtml

4. **wwwroot**
   - Statik dosyaları (CSS, JavaScript, resimler) içerir
   - Doğrudan erişilebilen genel dosyalardır
   Örnek: css/site.css ve js/site.js

### Önemli Yapılandırmalar

Program.cs dosyasında yapılan temel yapılandırmalar:

1. MVC Servisleri:

```csharp
services.AddControllersWithViews();
```

2. Statik Dosyalar:

```csharp
app.UseStaticFiles();
```

- wwwroot klasöründeki dosyalara erişimi sağlar
- CSS, JavaScript, resim gibi statik dosyaları sunar

3. Routing (Yönlendirme):

```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```

- Varsayılan routing şablonunu tanımlar
- URL yapısını belirler: /Controller/Action/Id
- Varsayılan controller: Home, varsayılan action: Index

4. HTTPS Yönlendirme:

```csharp
app.UseHttpsRedirection();
```

- HTTP isteklerini HTTPS'e yönlendirir
- Güvenli iletişimi zorunlu kılar

5. Yetkilendirme:

```csharp
app.UseAuthorization();
```

- Kullanıcı yetkilendirme sistemini aktif eder
- Rol tabanlı erişim kontrolünü sağlar

6. Geliştirme Ortamı Yapılandırması:

```csharp
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
```

- Geliştirme dışı ortamlarda hata yönetimini yapılandırır
- HSTS (HTTP Strict Transport Security) güvenliğini etkinleştirir

Bu yapılandırmalar, ASP.NET Core MVC uygulamasının temel işlevselliğini sağlar ve güvenli bir web uygulaması oluşturmak için gerekli olan minimum gereksinimleri karşılar.
