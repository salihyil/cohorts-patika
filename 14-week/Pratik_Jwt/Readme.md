# JWT Authentication API Projesi

Bu proje, .NET 9.0 kullanılarak geliştirilmiş bir JWT (JSON Web Token) authentication API örneğidir.

## Proje Açıklaması

Proje, kullanıcı kaydı ve girişi için JWT tabanlı kimlik doğrulama sistemi sunar. Scalar UI ile API dokümantasyonunu görüntüleyebilirsiniz.

## Başlangıç

API'yi başlatmak için:

1. Projeyi klonlayın
2. Veritabanı bağlantı ayarlarını `appsettings.json` dosyasında güncelleyin
3. Aşağıdaki komutları çalıştırın:

   ```bash
   dotnet restore
   dotnet run
   ```

4. Tarayıcınızda <http://localhost:5162/scalar/v1> adresini açın

## API Endpoints

### Auth Controller

- **POST /api/Auth/register**

  - Yeni kullanıcı kaydı
  - Body: `{ "email": "string", "password": "string" }`

- **POST /api/Auth/login**

  - Kullanıcı girişi
  - Body: `{ "email": "string", "password": "string" }`
  - Response: JWT token

- **GET /api/Auth/protected**
  - Korumalı endpoint örneği
  - Authorization: Bearer token gerekli

## Teknolojiler

- .NET 9.0
- Entity Framework Core
- JWT Authentication
- SQL Server
- Scalar UI (API Documentation)

## Güvenlik

- JWT token kullanılarak güvenli kimlik doğrulama
- Token süresi: 30 dakika
- Güvenli password saklama

## Geliştirme Ortamı

Projeyi geliştirme ortamında çalıştırmak için:

1. SQL Server'ı başlatın
2. Veritabanı migration'ları uygulayın:

   ```bash
   dotnet ef database update
   ```

3. Projeyi başlatın:

   ```bash
   dotnet run
   ```

API dokümantasyonu <http://localhost:5162/scalar/v1> adresinde otomatik olarak oluşturulacaktır.
