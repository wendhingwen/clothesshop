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
           new Clothing { Id = 1, Name = "", ModelNo = "", Price = 590, Description = "�p�����u�S�v��-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4044902_360.jpg", Photos = "4044902_360.jpg" },
           new Clothing { Id = 2, Name = "", ModelNo = "", Price = 590, Description = "�ӯ������v��-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4043201_360.jpg", Photos = "4043201_360.jpg" },
           new Clothing { Id = 3, Name = "", ModelNo = "", Price = 390, Description = "��UVù���s�U�~�M-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4069205_360.jpg", Photos = "4069205_360.jpg" },
           new Clothing { Id = 4, Name = "", ModelNo = "", Price = 390, Description = "�����s�U�~�M-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4041801_360.jpg", Photos = "4041801_360.jpg" },
           new Clothing { Id = 5, Name = "", ModelNo = "", Price = 390, Description = "Pima�֧�UV�C���S�w´�m-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4038504_360.jpg", Photos = "4038504_360.jpg" },
           new Clothing { Id = 6, Name = "", ModelNo = "", Price = 390, Description = "Pima�֧�UV�����C���S�w´�m-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4038603_360.jpg", Photos = "4038603_360.jpg" },
           new Clothing { Id = 7, Name = "", ModelNo = "", Price = 399, Description = "�e���u�S�w´�m-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4040003_360.jpg", Photos = "4040003_360.jpg" },
           new Clothing { Id = 8, Name = "", ModelNo = "", Price = 399, Description = "Pima �֧�UV�w´�~�M-�k", Size = "", Category = "�k��", Target = "female", Materials = "", MainPhoto = "4038909_360.jpg", Photos = "4038909_360.jpg" }
       );

            //Man
            context.Clothings.AddOrUpdate(
                x => x.Id,
                new Clothing { Id = 11, Name = "", ModelNo = "", Price = 390, Description = "�X�֪��SŨ�m-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4048506_360.jpg", Photos = "4048506_360.jpg" },
                new Clothing { Id = 12, Name = "", ModelNo = "", Price = 399, Description = "�ֳª��SŨ�m-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4045702_360.jpg", Photos = "4045702_360.jpg" },
                new Clothing { Id = 13, Name = "", ModelNo = "", Price = 399, Description = "�ֳ¥߻���SŨ�m-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4045903_360.jpg", Photos = "4045903_360.jpg" },
                new Clothing { Id = 14, Name = "", ModelNo = "", Price = 490, Description = "�Ӱȼu�ʪ��SŨ�m-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4043801_360.jpg", Photos = "4043801_360.jpg" },
                new Clothing { Id = 15, Name = "", ModelNo = "", Price = 390, Description = "�����s�U�~�M-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4041402_360.jpg", Photos = "4041402_360.jpg" },
                new Clothing { Id = 16, Name = "", ModelNo = "", Price = 490, Description = "�����t��s�U�~�M-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4041602_360.jpg", Photos = "4041602_360.jpg" },
                new Clothing { Id = 17, Name = "", ModelNo = "", Price = 299, Description = "STAR WARS�t�C���K�𶢵u��-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4032201_360.jpg", Photos = "4032201_360.jpg" },
                new Clothing { Id = 18, Name = "", ModelNo = "", Price = 390, Description = "�ְ���������polo�m-�k", Size = "", Category = "�k��", Target = "male", Materials = "", MainPhoto = "4072802_360.jpg", Photos = "4072802_360.jpg" }
            );

            //Child
            context.Clothings.AddOrUpdate(
                x => x.Id,
                new Clothing { Id = 21, Name = "", ModelNo = "", Price = 390, Description = "���~���Ҵ˥~�M-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4042801_360.jpg", Photos = "4042801_360.jpg" },
                new Clothing { Id = 22, Name = "", ModelNo = "", Price = 399, Description = "Peppa Pig�����L��s�U�~�M-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4042301_360.jpg", Photos = "4042301_360.jpg" },
                new Clothing { Id = 23, Name = "", ModelNo = "", Price = 399, Description = "��UVù���s�U�~�M-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4069901_360.jpg", Photos = "4069901_360.jpg" },
                new Clothing { Id = 24, Name = "", ModelNo = "", Price = 490, Description = "���J���SŨ�m-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4048201_360.jpg", Photos = "4048201_360.jpg" },
                new Clothing { Id = 25, Name = "", ModelNo = "", Price = 390, Description = "�X�֪��SŨ�m-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4067502_360.jpg", Photos = "4067502_360.jpg" },
                new Clothing { Id = 26, Name = "", ModelNo = "", Price = 490, Description = "�˸`�ֲ����W��-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4067502_360.jpg", Photos = "4067502_360.jpg" },
                new Clothing { Id = 27, Name = "", ModelNo = "", Price = 299, Description = "�H������S�W��-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4041302_360.jpg", Photos = "4041302_360.jpg" },
                new Clothing { Id = 28, Name = "", ModelNo = "", Price = 390, Description = "�˸`�֤f�U�e�P�W��-��", Size = "", Category = "����", Target = "child", Materials = "", MainPhoto = "4066503_360.jpg", Photos = "4066503_360.jpg" }
            );


            //shoes
            context.Shoes.AddOrUpdate(
                s => s.Id,
                new Shoes { Id = 1, Name = "", ModelNo = "", Price = 860, Description = "�x�W�s�D��u�s´�_�u�]�p�j�a���z�c", Size = "", Category = "�c", Target = "male", Materials = "", MainPhoto = "SD0181@1_50.jpg", Photos = "SD0098@1_50.jpg" },
                new Shoes { Id = 2, Name = "", ModelNo = "", Price = 379, Description = "�x�W�s�y.�W���q���u�O�����D��c�D5��", Size = "", Category = "�c", Target = "all", Materials = "", MainPhoto = "SD0098@1_50.jpg", Photos = "SD0098@1_50.jpg" },
                new Shoes { Id = 3, Name = "", ModelNo = "", Price = 379, Description = "�x�W�s�y~�W���q�u�O������c/�D�c", Size = "", Category = "�c", Target = "all", Materials = "", MainPhoto = "SD0186@1_50.jpg", Photos = "SD0186@1_50.jpg" },
                new Shoes { Id = 4, Name = "", ModelNo = "", Price = 299, Description = "�x�W�s�y~�r���ϼ˨�������թ�c", Size = "", Category = "�c", Target = "all", Materials = "", MainPhoto = "SD0182@1_50.jpg", Photos = "SD0182@1_50.jpg" },
                new Shoes { Id = 5, Name = "", ModelNo = "", Price = 299, Description = "�X�n�֭��y�Y�b��c/�p�Ǿc", Size = "", Category = "�c", Target = "male", Materials = "", MainPhoto = "SD0193@1_50.jpg", Photos = "SD0193@1_50.jpg" },
                new Shoes { Id = 6, Name = "", ModelNo = "", Price = 599, Description = "�x�W�s�y~���q��/�g�m�i�զ��u�֥𶢩�c", Size = "", Category = "�c", Target = "male", Materials = "", MainPhoto = "SD0184@1_50.jpg", Photos = "SD0184@1_50.jpg" },
                new Shoes { Id = 7, Name = "", ModelNo = "", Price = 479, Description = "�x�W�s�y~���Y���ֺ����òD�c", Size = "", Category = "�c", Target = "male", Materials = "", MainPhoto = "SD0190@1_50.jpg", Photos = "SD0190@1_50.jpg" },
                new Shoes { Id = 8, Name = "", ModelNo = "", Price = 650, Description = "�鹨��ô�a�y���ʸ�D�c/��c", Size = "", Category = "�c", Target = "male", Materials = "", MainPhoto = "SD0195@1_50.jpg", Photos = "SD0195@1_50.jpg" }
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
