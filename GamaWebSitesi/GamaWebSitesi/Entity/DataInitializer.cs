using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GamaWebSitesi.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { Name="Futbol Oyunları", Description = "Oyun" },
                new Category() { Name="Basketbol Oyunları", Description = "Oyun" },
                new Category() { Name="FPS Oyunları", Description = "Oyun" },
                new Category() { Name="Açık Dünya Oyunları", Description = "Oyun" },
                new Category() { Name="Hikayeli Oyunlar", Description = "Oyun" }
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name = "FIFA 22",Description = "FIFA 22",Price =11 ,Stock =100 ,IsApproved = true,CategoryId =1,IsHome = true,Image = "1.png"},
                new Product(){Name = "NBA 22",Description = "NBA 22",Price = 12,Stock = 100,IsApproved = true,CategoryId =2,IsHome = true,Image = "1.png" },
                new Product(){Name = "Valorant",Description = "Valorant",Price =13 ,Stock = 100,IsApproved = true,CategoryId =3,IsHome = true,Image = "1.png" },
                new Product(){Name = "GTA-V",Description = "GTA-V",Price =14 ,Stock = 100,IsApproved = true,CategoryId =4,IsHome = true,Image = "1.png" },
                new Product(){Name = "God Of War",Description = "God Of War",Price =25 ,Stock = 100,IsApproved =true ,CategoryId =5,Image = "1.png" },
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}