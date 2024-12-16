using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Code_First_Relation.Dtos.PostDto
{
    public class PostCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
    }
}

/* 
Bu DTO'nun özellikleri:
Id özelliği yok çünkü:
Id otomatik olarak veritabanı tarafından oluşturulacak
Yeni gönderi oluştururken Id'ye ihtiyacımız yok

Title ve Content özellikleri var çünkü:
Bunlar PostEntity'den referans alındı:

UserId özelliği var çünkü:
Gönderinin hangi kullanıcıya ait olduğunu belirtmek için gerekli
İlişkisel veri bağlantısını sağlar

User navigation property'si yok çünkü:
DTO'larda genellikle navigation property'ler kullanılmaz
Sadece gerekli veri transferi yapılır

Bu DTO yapısı:
Veri transferini optimize eder
Gereksiz veri taşınmasını önler
API güvenliğini artırır
İstemci tarafından sadece gerekli verilerin gönderilmesini sağlar
 */