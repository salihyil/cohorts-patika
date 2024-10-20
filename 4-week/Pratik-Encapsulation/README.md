# Pratik-Encapsulation

Bu proje, C#'ta kapsülleme (encapsulation) kavramını bir Araba sınıfı örneği üzerinden göstermektedir.

## Proje Açıklaması

Pratik-Encapsulation, nesne yönelimli programlamada kapsülleme kullanımını gösteren basit bir C# konsol uygulamasıdır. Proje, Marka, Model, Renk ve Kapı Sayısı gibi özelliklere sahip bir `Car` (Araba) sınıfı içerir. Kapı Sayısı özelliği, yalnızca geçerli değerlerin (2 veya 4) ayarlanabilmesini sağlamak için kapsüllenmiştir.

## Özellikler

- Marka, model, renk ve kapı sayısı ile Araba nesneleri oluşturma
- Girişi doğrulamak için Kapı Sayısı özelliğinin kapsüllenmesi
- Araba bilgilerinin görüntülenmesi

## Kod Yapısı

Proje iki ana dosyadan oluşur:

1. Program.cs: Main metodunu içerir ve Car sınıfının kullanımını gösterir.
2. Car.cs: Car sınıfını, özellikleri ve metodlarıyla tanımlar.

## Nasıl Çalıştırılır

1. Bilgisayarınızda .NET 8.0 SDK'nın yüklü olduğundan emin olun.
2. Bu depoyu yerel makinenize klonlayın.
3. Terminalinizde proje dizinine gidin.
4. Aşağıdaki komutu çalıştırın:

   ```
   dotnet run
   ```

## Örnek Çıktı

Program, farklı özelliklere sahip üç Araba nesnesi oluşturur ve bilgilerini görüntüler. İşte görebileceğiniz örnek bir çıktı:

```
Marka: Mercedes, Model: C180, Renk: Red, Kapı Sayısı: 2
--------------------------------
Kapı sayısı 2 veya 4 olmalıdır.
Marka: Audi, Model: A3, Renk: Black, Kapı Sayısı: -1
--------------------------------
Kapı sayısı 2 veya 4 olmalıdır.
Marka: BMW, Model: 320, Renk: White, Kapı Sayısı: -1
```
