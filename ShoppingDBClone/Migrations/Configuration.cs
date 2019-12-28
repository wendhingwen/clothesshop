namespace ShoppingDBClone.Migrations
{
    using ShoppingDBClone.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingDBClone.Models.ShoppingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingDBClone.Models.ShoppingContext context)
        {
            context.Clothings.AddOrUpdate(
           x => x.Id,
           new Clothing { Id = 1, Name = "", ModelNo = "", Price = 590, Description = "厚雪紡短袖洋裝-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4044902_360.jpg", Photos = "4044902_360.jpg" },
           new Clothing { Id = 2, Name = "", ModelNo = "", Price = 590, Description = "細紋雪紡洋裝-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4043201_360.jpg", Photos = "4043201_360.jpg" },
           new Clothing { Id = 3, Name = "", ModelNo = "", Price = 390, Description = "抗UV羅紋連帽外套-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4069205_360.jpg", Photos = "4069205_360.jpg" },
           new Clothing { Id = 4, Name = "", ModelNo = "", Price = 390, Description = "輕型連帽外套-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4041801_360.jpg", Photos = "4041801_360.jpg" },
           new Clothing { Id = 5, Name = "", ModelNo = "", Price = 390, Description = "Pima棉抗UV七分袖針織衫-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4038504_360.jpg", Photos = "4038504_360.jpg" },
           new Clothing { Id = 6, Name = "", ModelNo = "", Price = 390, Description = "Pima棉抗UV條紋七分袖針織衫-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4038603_360.jpg", Photos = "4038603_360.jpg" },
           new Clothing { Id = 7, Name = "", ModelNo = "", Price = 399, Description = "寬版短袖針織衫-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4040003_360.jpg", Photos = "4040003_360.jpg" },
           new Clothing { Id = 8, Name = "", ModelNo = "", Price = 399, Description = "Pima 棉抗UV針織外套-女", Size = "", Category = "男裝", Target = "female", Materials = "", MainPhoto = "4038909_360.jpg", Photos = "4038909_360.jpg" }
       );

            //Man
            context.Clothings.AddOrUpdate(
                x => x.Id,
                new Clothing { Id = 11, Name = "", ModelNo = "", Price = 390, Description = "柔棉長袖襯衫-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4048506_360.jpg", Photos = "4048506_360.jpg" },
                new Clothing { Id = 12, Name = "", ModelNo = "", Price = 399, Description = "棉麻長袖襯衫-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4045702_360.jpg", Photos = "4045702_360.jpg" },
                new Clothing { Id = 13, Name = "", ModelNo = "", Price = 399, Description = "棉麻立領長袖襯衫-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4045903_360.jpg", Photos = "4045903_360.jpg" },
                new Clothing { Id = 14, Name = "", ModelNo = "", Price = 490, Description = "商務彈性長袖襯衫-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4043801_360.jpg", Photos = "4043801_360.jpg" },
                new Clothing { Id = 15, Name = "", ModelNo = "", Price = 390, Description = "輕型連帽外套-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4041402_360.jpg", Photos = "4041402_360.jpg" },
                new Clothing { Id = 16, Name = "", ModelNo = "", Price = 490, Description = "輕型配色連帽外套-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4041602_360.jpg", Photos = "4041602_360.jpg" },
                new Clothing { Id = 17, Name = "", ModelNo = "", Price = 299, Description = "STAR WARS系列輕便休閒短褲-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4032201_360.jpg", Photos = "4032201_360.jpg" },
                new Clothing { Id = 18, Name = "", ModelNo = "", Price = 390, Description = "快乾網眼徽章polo衫-男", Size = "", Category = "女裝", Target = "male", Materials = "", MainPhoto = "4072802_360.jpg", Photos = "4072802_360.jpg" }
            );

            //Child
            context.Clothings.AddOrUpdate(
                x => x.Id,
                new Clothing { Id = 21, Name = "", ModelNo = "", Price = 390, Description = "水洗布勞森外套-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4042801_360.jpg", Photos = "4042801_360.jpg" },
                new Clothing { Id = 22, Name = "", ModelNo = "", Price = 399, Description = "Peppa Pig輕型印花連帽外套-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4042301_360.jpg", Photos = "4042301_360.jpg" },
                new Clothing { Id = 23, Name = "", ModelNo = "", Price = 399, Description = "抗UV羅紋連帽外套-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4069901_360.jpg", Photos = "4069901_360.jpg" },
                new Clothing { Id = 24, Name = "", ModelNo = "", Price = 490, Description = "牛仔長袖襯衫-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4048201_360.jpg", Photos = "4048201_360.jpg" },
                new Clothing { Id = 25, Name = "", ModelNo = "", Price = 390, Description = "柔棉長袖襯衫-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4067502_360.jpg", Photos = "4067502_360.jpg" },
                new Clothing { Id = 26, Name = "", ModelNo = "", Price = 490, Description = "竹節棉荷葉上衣-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4067502_360.jpg", Photos = "4067502_360.jpg" },
                new Clothing { Id = 27, Name = "", ModelNo = "", Price = 299, Description = "碎花荷葉袖上衣-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4041302_360.jpg", Photos = "4041302_360.jpg" },
                new Clothing { Id = 28, Name = "", ModelNo = "", Price = 390, Description = "竹節棉口袋寬鬆上衣-童", Size = "", Category = "童裝", Target = "child", Materials = "", MainPhoto = "4066503_360.jpg", Photos = "4066503_360.jpg" }
            );


            //shoes
            context.Shoes.AddOrUpdate(
                s => s.Id,
                new Shoes { Id = 1, Name = "", ModelNo = "", Price = 860, Description = "台灣製．手工編織縫線設計綁帶牛津鞋", Size = "", Category = "鞋", Target = "male", Materials = "", MainPhoto = "SD0181@1_50.jpg", Photos = "SD0098@1_50.jpg" },
                new Shoes { Id = 2, Name = "", ModelNo = "", Price = 379, Description = "台灣製造.超輕量高彈力防水涼拖鞋．5色", Size = "", Category = "鞋", Target = "all", Materials = "", MainPhoto = "SD0098@1_50.jpg", Photos = "SD0098@1_50.jpg" },
                new Shoes { Id = 3, Name = "", ModelNo = "", Price = 379, Description = "台灣製造~超輕量彈力防水拖鞋/涼鞋", Size = "", Category = "鞋", Target = "all", Materials = "", MainPhoto = "SD0186@1_50.jpg", Photos = "SD0186@1_50.jpg" },
                new Shoes { Id = 4, Name = "", ModelNo = "", Price = 299, Description = "台灣製造~字母圖樣防潑水輕盈拖鞋", Size = "", Category = "鞋", Target = "all", Materials = "", MainPhoto = "SD0182@1_50.jpg", Photos = "SD0182@1_50.jpg" },
                new Shoes { Id = 5, Name = "", ModelNo = "", Price = 299, Description = "柔軟皮革尖頭半拖鞋/穆勒鞋", Size = "", Category = "鞋", Target = "male", Materials = "", MainPhoto = "SD0193@1_50.jpg", Photos = "SD0193@1_50.jpg" },
                new Shoes { Id = 6, Name = "", ModelNo = "", Price = 599, Description = "台灣製造~棕櫚葉/迷彩可調式真皮休閒拖鞋", Size = "", Category = "鞋", Target = "male", Materials = "", MainPhoto = "SD0184@1_50.jpg", Photos = "SD0184@1_50.jpg" },
                new Shoes { Id = 7, Name = "", ModelNo = "", Price = 479, Description = "台灣製造~圓頭漆皮瑪莉珍涼鞋", Size = "", Category = "鞋", Target = "male", Materials = "", MainPhoto = "SD0190@1_50.jpg", Photos = "SD0190@1_50.jpg" },
                new Shoes { Id = 8, Name = "", ModelNo = "", Price = 650, Description = "仿麂皮繫帶造型粗跟涼鞋/拖鞋", Size = "", Category = "鞋", Target = "male", Materials = "", MainPhoto = "SD0195@1_50.jpg", Photos = "SD0195@1_50.jpg" }
            );

            //Carousel
            context.Carousel.AddOrUpdate(
                c => c.Id,
                new Carousel { Id = 1, Name = "ShoesBanner01", Description = "", Photo = "ShoesBanner01.jpg", Url = "", Published = true, Locked = false },
                new Carousel { Id = 2, Name = "ShoesBanner02", Description = "", Photo = "ShoesBanner02.jpg", Url = "", Published = true, Locked = false },
                new Carousel { Id = 3, Name = "ShoesBanner03", Description = "", Photo = "ShoesBanner03.jpg", Url = "", Published = true, Locked = false }
            );
        }
    }
}
