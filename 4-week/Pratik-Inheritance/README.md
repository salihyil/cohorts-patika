# Pratik Inheritance Projesi

Bu proje, C# programlama dilinde kalıtım (inheritance) kavramını uygulamalı olarak göstermek için tasarlanmıştır.

## Proje Açıklaması

Bu projede, bir temel sınıf olan `Person` ve ondan türetilen `Student` ve `Teacher` sınıfları bulunmaktadır. Proje, nesne yönelimli programlamanın temel prensiplerinden biri olan kalıtımı göstermektedir.

### Sınıf Yapısı

1. **Person (Temel Sınıf)**
   - Özellikler: Ad (Name), Soyad (Surname)
   - Metotlar: PrintInfo() (Bilgileri yazdırma)

2. **Student (Öğrenci Sınıfı)**
   - Person sınıfından türetilmiştir
   - Ek Özellik: Öğrenci Numarası (StudentNo)
   - Metotlar: PrintInfo() (override edilmiş)

3. **Teacher (Öğretmen Sınıfı)**
   - Person sınıfından türetilmiştir
   - Ek Özellik: Maaş (Salary)
   - Metotlar: PrintInfo() (override edilmiş)

## Nasıl Çalışır?

Program.cs dosyasında, örnek bir öğrenci ve öğretmen nesnesi oluşturulur ve bilgileri konsola yazdırılır.

## Önemli Noktalar

- Proje, kalıtım kavramını göstermektedir.
- Soyut (abstract) sınıf kullanımı mevcuttur.
- Property'lerin kullanımı ve basit doğrulama örnekleri içermektedir.
- Metot override etme örnekleri bulunmaktadır.

## Nasıl Çalıştırılır?

1. Projeyi bilgisayarınıza klonlayın.
2. Visual Studio veya tercih ettiğiniz bir C# IDE'sinde projeyi açın.
3. Program.cs dosyasını çalıştırın.
