# Polimorfizm Pratiği

Bu proje, C# programlama dilinde polimorfizm kavramını uygulamalı olarak göstermek için tasarlanmıştır. Projede, farklı geometrik şekillerin (kare, dikdörtgen ve dik üçgen) alan hesaplamalarını yapan bir uygulama geliştirilmiştir.

## Proje Yapısı

Proje aşağıdaki ana bileşenlerden oluşmaktadır:

1. `BaseGeometricShape`: Tüm geometrik şekillerin temel sınıfı.
2. `Square`: Kare sınıfı.
3. `Rectangle`: Dikdörtgen sınıfı.
4. `RightTriangle`: Dik üçgen sınıfı.

## Özellikler

- Her geometrik şekil için alan hesaplama işlevi.
- Polimorfizm kullanılarak farklı şekillerin alanlarının hesaplanması.
- Negatif boyutlara karşı hata kontrolü.

## Nasıl Çalışır?

Program, her bir geometrik şekil için bir örnek oluşturur ve alanlarını hesaplar. Sonuçlar konsol ekranında gösterilir.

## Kullanım

Projeyi çalıştırmak için:

1. Projeyi klonlayın veya indirin.
2. Visual Studio veya tercih ettiğiniz bir C# IDE'sinde projeyi açın.
3. `Program.cs` dosyasını çalıştırın.

## Örnek Çıktı

Kare Alanı: 25

Dikdörtgen Alanı: 50

Dik Üçgen Alanı: 28.875
