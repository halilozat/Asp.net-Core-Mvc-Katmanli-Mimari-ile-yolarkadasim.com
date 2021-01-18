using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YolArkadasim.Entities.Concrete;

namespace YolArkadasim.Data.Concrete.EntityFramework.Mappings
{
    public class JourneyMap:IEntityTypeConfiguration<Journey>
    {
        public void Configure(EntityTypeBuilder<Journey> builder)
        {
            builder.HasKey(a => a.Id); //İd primary key oldu
            builder.Property(a => a.Id).ValueGeneratedOnAdd(); //identity alanı
            builder.Property(a => a.JourneyStart).HasMaxLength(100);  //max 100 karakter
            builder.Property(a => a.JourneyStart).IsRequired();//zorunlu mu?
            builder.Property(a => a.JourneyFinish).HasMaxLength(100);
            builder.Property(a => a.JourneyFinish).IsRequired();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true); //zorunlu mu? (default=true)
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Journeys).HasForeignKey(a => a.CategoryId);
            //bir kategorinin birden fazla yolculuğu olabilir, bir yolculuğun bir kategorisi olabilir.
            //HasForeignKey : ikincil bir anahtar değeri var mı? --> a => a.CategoryId
            builder.HasOne<User>(a => a.User).WithMany(u => u.Journeys).HasForeignKey(a => a.UserId);
            builder.ToTable("Journeys");//tablo ismi

          
            
            
            
            
            
            
            //builder.HasData(
            //    new Journey
            //    {
            //        Id = 1,
            //        CategoryId = 1,
            //        JourneyStart = "Manisa",
            //        JourneyFinish = "İzmir",
            //        Title = "Arabama Yol Arkadaşı Arıyorum",
            //        Content =
            //            "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
            //        Thumbnail = "Default.jpg",
            //        SeoDescription = "Yan Koltuğumda 1 kişilik yer var",
            //        SeoTags = "Araba, Yolculuk",
            //        SeoAuthor = "Halil Ozat",
            //        Date = DateTime.Now,
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "Yol Arkadaşı Arıyorum",
            //        UserId = 1,
            //        ViewCount = 100,
            //        CommentCount = 1
            //    },
            //    new Journey
            //    {
            //        Id = 2,
            //        CategoryId = 2,
            //        JourneyStart = "Manisa",
            //        JourneyFinish = "İzmir",
            //        Title = "Motorumla Yol Alacağım",
            //        Content =
            //            "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
            //        Thumbnail = "Default.jpg",
            //        SeoDescription = "Motor",
            //        SeoTags = "Motor, Yolculuk",
            //        SeoAuthor = "Kardeşler Ulaşım",
            //        Date = DateTime.Now,
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "Motor Yolculuğu",
            //        UserId = 2,
            //        ViewCount = 295,
            //        CommentCount = 1
            //    },
            //    new Journey()
            //    {
            //        Id = 3,
            //        CategoryId = 3,
            //        JourneyStart = "Manisa",
            //        JourneyFinish = "İzmir",
            //        Title = "Minibüsümüzde Yer Var",
            //        Content =
            //            "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir. 1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir.",
            //        Thumbnail = "Default.jpg",
            //        SeoDescription = "Mibibüs",
            //        SeoTags = "Minibüs, Yolculuk",
            //        SeoAuthor = "Kardeşler Ulaşım",
            //        Date = DateTime.Now,
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "Ucuz Yolculuk",
            //        UserId = 2,
            //        ViewCount = 12,
            //        CommentCount = 1
            //    }
            //);
        }
    }
}
