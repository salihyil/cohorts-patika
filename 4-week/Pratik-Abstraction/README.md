# Çalışan Yönetim Sistemi

Bu proje, bir şirketin çalışanlarını temsil eden basit bir C# konsol uygulamasıdır. Proje, nesne yönelimli programlamanın temel prensiplerinden biri olan soyutlama (abstraction) kavramını göstermek için tasarlanmıştır.

## Proje Hakkında

Bu uygulama, farklı pozisyonlardaki çalışanları temsil eden bir sistem oluşturur. Her çalışan için ortak özellikler (ad, soyad, departman) bulunurken, her çalışanın görevi (pozisyonu) farklılık gösterebilir.

## Özellikler

- Soyut `Employee` sınıfı ile temel çalışan özellikleri ve metodları tanımlanmıştır.
- Farklı çalışan tipleri (`SoftwareDeveloper`, `ProjectManager`, `SalesRepresentative`) `Employee` sınıfından türetilmiştir.
- Her çalışan tipi, kendi görevini açıklayan özel bir `Task()` metodu uygulamaktadır.

## Kullanım

Program çalıştırıldığında, farklı tiplerde çalışanlar oluşturulur ve her birinin bilgileri ile görevleri konsol ekranında gösterilir.

## Proje Yapısı

Proje iki ana dosyadan oluşmaktadır:

1. `Program.cs`: Ana program akışını içerir.
2. `Employee.cs`: Çalışan sınıflarının tanımlamalarını içerir.

## Nasıl Çalıştırılır

1. Projeyi klonlayın veya indirin.
2. Visual Studio veya tercih ettiğiniz bir C# IDE'sinde projeyi açın.
3. Projeyi derleyin ve çalıştırın.

## Geliştirme

Bu proje, nesne yönelimli programlama ve soyutlama kavramlarını öğrenmek veya öğretmek için bir örnek olarak kullanılabilir. Yeni çalışan tipleri ekleyerek veya mevcut yapıyı genişleterek projeyi geliştirebilirsiniz.
