namespace Pratik_AspNet_Core_Empty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

            /*
            ASP.NET Core MVC'deki Temel Kavramlar:

            1. Controller (Denetleyici):
            - HTTP isteklerini işleyen sınıflardır
            - İstekleri işleyip yanıt döndüren action metotlarını içerir
            - Model ve View arasındaki koordinasyonu sağlar
            Örnek: HomeController, /Home/Index isteklerini işler

            2. Action (Eylem):
            - Controller içindeki HTTP isteklerine yanıt veren metotlardır
            - Kullanıcı girdilerini işler ve sonuç döndürür
            - View, JSON, dosya vb. dönebilir
            Örnek: HomeController içindeki Index() metodu

            3. Model (Veri Modeli):
            - Veriyi ve iş mantığını temsil eder
            - Veri yapısını tanımlayan düz C# sınıflarıdır
            - Doğrulama ve iş kurallarını içerebilir
            Örnek: Ad, Soyad özelliklerine sahip TestViewModel sınıfı

            4. View (Görünüm):
            - HTML oluşturmak için kullanılan şablonlardır
            - Views klasöründe, controller'a göre düzenlenir
            - HTML içinde C# kodu yazmak için Razor sözdizimini kullanır
            Örnek: TestViewModel verilerini gösteren About.cshtml

            5. Razor:
            - HTML içinde C# kodu yazmak için kullanılan şablon sözdizimi
            - C# koduna geçiş için @ sembolünü kullanır
            - Dinamik içerik oluşturmayı sağlar
            Örnek: About.cshtml içinde @Model.Name kullanımı

            6. RazorView:
            - Razor sözdizimi ve HTML'in birleşimidir
            - @model direktifi ile güçlü tipli görünümler sağlar
            - Layout ve partial view'ları kullanabilir
            Örnek: Paylaşılan _Layout.cshtml düzeni

            7. wwwroot:
            - Statik dosyaları (CSS, JS, resimler) içerir
            - Herkese açık dosyalardır
            - Doğrudan istemcilere sunulur
            Örnek: css/site.css

            Önemli Metotlar:

            8. builder.Build():
            - Servis yapılandırmasını tamamlar
            - WebApplication örneği oluşturur
            - Uygulama pipeline'ını kurar
            - Middleware yapılandırmasından önce çağrılmalıdır

            9. app.Run():
            - Web uygulamasını başlatır
            - HTTP isteklerini dinlemeye başlar
            - Uygulama kapatılana kadar bloklar
            - En son çağrılması gereken metottur

            Bu mimari, MVC (Model-View-Controller) desenini takip eder ve şu şekilde ayrılır:
            - Veri (Models)
            - Kullanıcı Arayüzü (Views)
            - Uygulama Mantığı (Controllers)
            */
        }
    }
}
