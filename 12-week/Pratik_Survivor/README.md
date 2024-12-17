# Pratik Survivor

Pratik Survivor, .NET 8.0 üzerinde geliştirilmiş bir web uygulamasıdır. Bu proje, Entity Framework Core ve ASP.NET Core kullanarak bir Survivor yarışması simülasyonu sunar.

## Özellikler

- **Entity Framework Core**: Veritabanı işlemleri için kullanılır.
- **ASP.NET Core**: Web uygulaması geliştirme için kullanılır.
- **Swashbuckle**: API dokümantasyonu için kullanılır.

## Gereksinimler

- .NET 8.0 SDK
- SQL Server

## Kurulum

1. **Depoyu Klonlayın:**

   ```bash
   git clone https://github.com/salihyil/cohorts-patika.git
   cd cohorts-patika/12-week/Pratik_Survivor
   ```

2. **Bağımlılıkları Yükleyin:**

   Proje dizininde aşağıdaki komutu çalıştırarak NuGet paketlerini yükleyin:

   ```bash
   dotnet restore
   ```

3. **Veritabanını Ayarlayın:**

   `appsettings.json` dosyasındaki `ConnectionStrings` bölümünü kendi SQL Server ayarlarınıza göre güncelleyin.

4. **Veritabanı Migrasyonlarını Uygulayın:**

   ```bash
   dotnet ef database update
   ```

5. **Uygulamayı Çalıştırın:**

   ```bash
   dotnet run
   ```

## Kullanım

Uygulama çalıştırıldığında, varsayılan olarak `http://localhost:5214` adresinde erişilebilir olacaktır. Swagger arayüzü üzerinden API dokümantasyonuna erişebilir ve API'yi test edebilirsiniz.

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın.
