# Pratik-Constructor

Bu proje, C#'ta constructor (yapıcı metot) kullanımını basit bir `Bebek` sınıfı uygulaması üzerinden göstermektedir.

## Proje Açıklaması

Pratik-Constructor projesi, bir sınıf içinde birden fazla constructor'ın oluşturulmasını ve kullanımını gösteren bir konsol uygulamasıdır. Projede, bir bebeğin adı, soyadı ve doğum tarihini içeren özelliklere sahip bir `Bebek` sınıfı bulunmaktadır.

## Özellikler

- `Bebek` sınıfı özellikleri: Ad, Soyad ve DoğumTarihi
- `Bebek` sınıfı için iki constructor:
  1. Varsayılan (parametresiz) constructor
  2. Ad ve soyad parametrelerini alan constructor
- Doğum tarihinin otomatik olarak mevcut tarih ve saate ayarlanması
- Yeni bir `Bebek` nesnesi oluşturulduğunda konsola "Ingaaaa" yazdırılması

## Nasıl Çalıştırılır

1. Bilgisayarınızda .NET 8.0 SDK'nın yüklü oldu��undan emin olun.
2. Bu depoyu (repository) yerel makinenize klonlayın.
3. Terminal veya komut istemcisinde proje dizinine gidin.
4. Aşağıdaki komutu çalıştırın:
   ```
   dotnet run
   ```

## Kod Yapısı

Proje iki ana dosyadan oluşmaktadır:

1. `Program.cs`: `Main` metodunu içerir ve `Bebek` sınıfının kullanımını gösterir.
2. `Bebek.cs`: `Bebek` sınıfını, özelliklerini ve constructor'larını tanımlar.

## Örnek Kullanım

`Program.cs` dosyasındaki `Main` metodu, her iki constructor'ı kullanarak `Bebek` nesnelerinin nasıl oluşturulacağını göstermektedir:

