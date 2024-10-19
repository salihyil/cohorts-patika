# Pratik-Patika-Kütüphane

Pratik-Patika-Kütüphane, Kitap sınıfını kullanarak temel nesne yönelimli programlama kavramlarını gösteren basit bir C# konsol uygulamasıdır.

## Proje Açıklaması

Bu proje, C#'ta sınıfların, özelliklerin, yapıcıların ve nesne örneklemesinin uygulanmasını gösteren bir programlama alıştırmasının parçasıdır. Kitap nesneleri oluşturur, yönetir ve bunların detaylarını konsol arayüzü üzerinden gösterir.

## Özellikler

- Çeşitli özelliklere sahip (Başlık, Yazarın Adı, Yazarın Soyadı, Sayfa Sayısı, Yayınevi) Kitap nesneleri oluşturma
- Özel bir metot kullanarak kitap detaylarını görüntüleme
- Farklı yapıcı türlerinin (parametresiz ve parametreli) kullanımını gösterme

## Başlangıç

### Gereksinimler

- .NET 8.0 SDK veya daha yenisi
- Herhangi bir C# IDE'si (Visual Studio, C# uzantılı Visual Studio Code, JetBrains Rider vb.)

### Kurulum

1. Depoyu klonlayın:
   ```
   git clone https://github.com/kullanıcıadınız/Pratik-Patika-Kutuphane.git
   ```
2. Proje dizinine gidin:
   ```
   cd Pratik-Patika-Kutuphane
   ```
3. Projeyi derleyin:
   ```
   dotnet build
   ```
4. Uygulamayı çalıştırın:
   ```
   dotnet run
   ```

## Kullanım

Uygulama, Kitap nesnelerinin oluşturulmasını ve detaylarının görüntülenmesini gösterir. Şunları sergiler:

1. Parametreli yapıcı kullanarak bir Kitap nesnesi oluşturma
2. Parametresiz yapıcı kullanarak bir Kitap nesnesi oluşturma ve özellikleri tek tek ayarlama
3. `PrintBookDetails()` metodunu kullanarak kitap detaylarını görüntüleme

## Proje Yapısı

- `Program.cs`: Ana giriş noktasını içerir ve Kitap sınıfının kullanımını gösterir
- `Book.cs`: Özellikler ve metotlarla Kitap sınıfını tanımlar (verilen kod parçalarında gösterilmemiştir, ancak var olduğu varsayılmaktadır)

## Öğrenme Hedefleri

Bu proje, C#'taki temel OOP kavramlarının anlaşılmasını pekiştirmeye yardımcı olur:

- Sınıflar: Kitap sınıfı tarafından tanımlanır, kitaplarla ilgili veri ve davranışları kapsar
- Özellikler: Kitap özelliklerini almak ve ayarlamak için kullanılır (Başlık, YazarAdı vb.)
- Yapıcılar: Hem parametresiz hem de parametreli yapıcıların kullanımı gösterilir
- Nesne Örnekleme: `new` anahtar kelimesi kullanılarak yeni Kitap nesneleri oluşturma

## Katkıda Bulunma

Bu bir alıştırma projesidir, ancak öneriler ve iyileştirmeler memnuniyetle karşılanır. Lütfen depoyu çatallayıp (fork) pull request göndermekten çekinmeyin.
