using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avaweb.Models
{
    public class OutstandingFeatures
    {
        public string feature { get; set; }
    }
    public class Type
    {
        public string Nametype { get; set; }
    }
    public class Usermanual
    {
        public string NameManual { get; set; }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal PriceOld { get; set; }
        public string Image { get; set; }
        public List<Product> OtherProduct { get; set; }
        public string Tredemark { get; set; }
        public List<Type> type { get; set; }
        public string Age { get; set; }
        public string substance { get; set; }
        public string Boxsize { get; set; }
        public string Weight { get; set; }
        public string Note { get; set; }
        public string production { get; set; }
        public List<OutstandingFeatures> Outstanding { get; set; }
        public List<Usermanual> Manual { get; set; }



        

    }
    public class ProductModel
    {
        public List<Product> ProductMain { get; set; }

        public ProductModel()
        {
            ProductMain = new List<Product>()
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                    Price = 1993200,
                    PriceOld = 1399000,
                    Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",
                    Tredemark = "Lego (Đan Mạch)",
                    type = new List<Type>()
                    {
                        new Type
                        {
                            Nametype = "Đồ chơi bé trai"
                        },
                        new Type
                        {
                            Nametype = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = "5",
                    substance = "Nhựa",
                    Boxsize = "38x26x6 cm",
                    Weight = "724 g",
                    Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    production = "Trung Quốc",
                      Outstanding = new List<OutstandingFeatures>(){
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308"
                        },
                        new OutstandingFeatures
                        {
                            feature="Bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new OutstandingFeatures
                        {
                            feature=" giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp."
                        },
                        new OutstandingFeatures
                        {
                            feature="không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }

                    },
                Manual =new List<Usermanual>()
                {
                    new Usermanual
                    {
                        NameManual="Đồ chơi không dùng pin.",

                    },
                    new Usermanual
                    {
                        NameManual="Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                    },
                    new Usermanual
                    {
                        NameManual="Có thể sáng tạo theo trí tưởng tượng của bé.",
                    }
                },
                    OtherProduct = new List<Product>
                    {
                        new Product
                        {
                             ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                          new Product
                        {
                             ProductID = 3,
                            ProductName = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        },
                            new Product
                        {
                             ProductID = 4,
                            ProductName = "Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                              new Product
                        {
                             ProductID = 5,
                            ProductName = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                                new Product
                        {
                             ProductID = 6,
                            ProductName = "Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                                  new Product
                        {
                             ProductID = 7,
                            ProductName = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },


                    }

                },
                new Product
                {
                    ProductID =2,
                    ProductName="Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                    Price=1993200,
                    PriceOld=138099,
                    Image="do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                    Tredemark="Lego (Đan Mạch)",
                    type =new List<Type>()
                    {
                        new Type
                        {
                            Nametype="Đồ chơi bé trai"
                        },
                        new Type
                        {
                            Nametype="Đồ chơi lắp ráp"
                        }
                    },
                    Age= "Từ 4 tuổi trở lên",
                    substance="Nhựa",
                    Boxsize="38x26x5.6 cm",
                    Weight="595 g",
                    Note="Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    production="Trung Quốc",
                      Outstanding = new List<OutstandingFeatures>(){
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308"
                        },
                        new OutstandingFeatures
                        {
                            feature="Bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new OutstandingFeatures
                        {
                            feature=" giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp."
                        },
                        new OutstandingFeatures
                        {
                            feature="không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }

                    },
                Manual =new List<Usermanual>()
                {
                    new Usermanual
                    {
                        NameManual="Đồ chơi không dùng pin.",

                    },
                    new Usermanual
                    {
                        NameManual="Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                    },
                    new Usermanual
                    {
                        NameManual="Có thể sáng tạo theo trí tưởng tượng của bé.",
                    }
                },
                OtherProduct = new List<Product>()
                {
                   new Product
                   {
                    ProductID = 1,
                    ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                    Price = 1993200,
                    PriceOld = 1399000,
                    Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",

                   },
                   new Product
                   {
                    ProductID = 3,
                    ProductName = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"

                   },
                   new Product
                   {
                     ProductID = 4,
                     ProductName = "Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                    Price = 993200,
                    PriceOld = 1399000,
                  Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"

                   },
                   new Product
                   {
                        ProductID = 5,
                            ProductName = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                   },
                   new Product
                   {
                        ProductID = 6,
                            ProductName = "Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"

                   },
                   new Product
                   {
                        ProductID = 7,
                            ProductName = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"

                   }
                }








                },
                new Product
                {
                ProductID = 3,
                    ProductName = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg",

                    Tredemark = "HOT WHEELS (Mỹ)",
                    type = new List<Type>()
                    {
                        new Type
                        {
                            Nametype = "Đồ chơi bé trai"
                        },
                        new Type
                        {
                            Nametype = "Đồ chơi nhập vai"
                        }
                    },
                    Age = "Từ 4 đến 8 tuổi",
                    substance = "Nhựa,Kim Loại",
                    Boxsize = "56x30x15  cm",
                    Weight = "1071 g",
                    Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    production = "Trung Quốc",
                      Outstanding = new List<OutstandingFeatures>(){
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66  trang bị đầy đủ các tính năng rửa xe sống động."
                        },
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi Hot Wheels có thể kết hợp với nhiều mô hình khác giúp bé khám phá thế giới xung quanh."
                        },
                        new OutstandingFeatures
                        {
                            feature=" Đồ chơi vận động  không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }

                    },
                Manual =new List<Usermanual>()
                {

                    new Usermanual
                    {
                        NameManual="Đồ chơi  dùng để chơi và trưng bày.",
                    }
                },
                    OtherProduct = new List<Product>
                    {
                        new Product
                        {
                             ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                          new Product
                        {
                             ProductID = 1,
                           ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                    Price = 1993200,
                    PriceOld = 1399000,
                    Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",
                        },
                            new Product
                        {
                             ProductID = 4,
                            ProductName = "Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                              new Product
                        {
                             ProductID = 5,
                            ProductName = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                                new Product
                        {
                             ProductID = 6,
                            ProductName = "Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                                  new Product
                        {
                             ProductID = 7,
                            ProductName = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },


                    }

                },
                new Product
                {
                    ProductID =4,
                    ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                    Price=993200,
                    PriceOld=1399000,
                    Image="do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg",
                    Tredemark="Lego (Đan Mạch)",
                    type= new List<Type>()
                    {
                        new Type
                        {
                            Nametype="Đồ chơi bé gái"
                        },
                        new Type
                        {
                            Nametype="Đồ chơi bé trai"
                        },
                        new Type
                        {
                            Nametype="Đồ chơi lắp ráp",
                        }
                    },
                    Age="Từ 1.5 tuổi trở lên",
                    substance="Nhựa",
                    Boxsize="36.5x19x18 cm",
                    Weight="1046 g",
                    Note="Chỉ thích hợp cho trẻ em từ 1.5 tuổi trở lên",
                    production="Trung Quốc",
                    Outstanding=new List<OutstandingFeatures>
                    {
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 bao gồm 65 chi tiết.",
                        },
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi học tập giúp bé tập làm quen với các con số"
                        },
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi giúp bé phát triển tư duy, sáng tạo khi chơi."
                        },
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi Lego có các góc được bo tròn an toàn cho bé."

                        }
                    },
                    Manual= new List<Usermanual>()
                    {
                        new Usermanual
                        {
                            NameManual="Lắp ráp các khớp nối với nhau theo hình trên bao bì.",
                        },
                        new Usermanual
                        {
                            NameManual="Có thể sáng tạo theo trí tưởng tượng của bé.",
                        }
                    },
                    OtherProduct= new List<Product>(){
                       new Product
                        {
                        ProductID = 1,
                        ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                        Price = 1993200,
                        PriceOld = 1399000,
                        Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",
                        },
                       new Product
                        {
                        ProductID = 2,
                        ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                        Price = 993200,
                        PriceOld = 1399000,
                        Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                        new Product
                   {
                    ProductID = 3,
                    ProductName = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"

                   },

                          new Product
                   {
                        ProductID = 5,
                            ProductName = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                   },
                          new Product
                   {
                        ProductID = 6,
                            ProductName = "Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"

                   },
                            new Product
                   {
                        ProductID = 7,
                            ProductName = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"

                   }









                    }




                },
                new Product
                {
                    ProductID=5,
                    ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                    Tredemark="Lego (Đan Mạch)",
                    type=new List<Type>()
                    {
                        new Type
                        {
                            Nametype="Đồ chơi bé gái"
                        },
                        new Type
                        {
                            Nametype="Đồ chơi bé trai"
                        },
                        new Type{
                            Nametype="Đồ chơi lắp ráp"
                        }

                    },
                    Age="Từ 1.5 tuổi trở lên",
                    substance="Nhựa",
                    Boxsize="36.5x19x18 cm",
                    Weight="1046 g",
                    Note="Chỉ thích hợp cho trẻ em từ 1.5 tuổi trở lên",
                    production="Trung Quốc",
                    Outstanding = new List<OutstandingFeatures>()
                    {
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 bao gồm 65 chi tiết.",
                        },
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi học tập giúp bé tập làm quen với các con số"
                        },
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi giúp bé phát triển tư duy, sáng tạo khi chơi."
                        },
                        new OutstandingFeatures
                        {
                            feature="Đồ chơi Lego có các góc được bo tròn an toàn cho bé."
                        }



                    },
                    Manual=new List<Usermanual>()
                    {
                        new Usermanual
                        {
                            NameManual="Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Usermanual
                        {
                            NameManual="Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    },
                    OtherProduct=new List<Product>()
                    {
                        new Product
                        {
                        ProductID = 1,
                        ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                        Price = 1993200,
                        PriceOld = 1399000,
                        Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",
                        },
                         new Product
                        {
                        ProductID = 2,
                        ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                        Price = 993200,
                        PriceOld = 1399000,
                        Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                         new Product
                   {
                    ProductID = 3,
                    ProductName = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"

                   },
                         new Product
                         {
                             ProductID=4,
                             ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                             Price=993200,
                             PriceOld=1399000,
                             Image="do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                         },
                         new Product
                   {
                     ProductID = 6,
                     ProductName = "Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                     Price = 993200,
                     PriceOld = 1399000,
                     Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"

                   },
                          new Product
                   {
                     ProductID = 7,
                     ProductName = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                     Price = 993200,
                     PriceOld = 1399000,
                     Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"

                   }


                    }

                },
                new Product
                {
            ProductID=6,
            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
            Price=993200,
            PriceOld=1399000,
            Image="do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg",
            Tredemark="Lego (Đan Mạch)",
            type=new List<Type>()
            {
                new Type
                {
                    Nametype="Đồ chơi bé trai",
                    
                },
                new Type
                {
                    Nametype="Đồ chơi lắp ráp"
                }
            },
            Age="Từ 8 tuổi trở lên",
            substance="Nhựa",
            Boxsize="38x25.8x5.6 cm",
            Weight="672 g",
            Note="Không có",
            production="Trung Quốc",

            Outstanding=new List<OutstandingFeatures>()
            {
                new OutstandingFeatures
                {
                    feature="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 bao gồm 449 chi tiết."
                },
                new OutstandingFeatures
                {
                    feature="Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."

                },
                new OutstandingFeatures
                {
                    feature="Đồ chơi Lego giúp bé rèn luyện tính tỉ mỉ, sáng tạo khi lắp ráp."
                },
                new OutstandingFeatures
                {
                    feature="Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                }
            },
            Manual=new List<Usermanual>()
            {
                new Usermanual
                {
                    NameManual="Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                },
                new Usermanual
                {
                    NameManual="Có thể sáng tạo theo trí tưởng tượng của bé."
                }
            },
            OtherProduct=new List<Product>()
            {
                new Product
                        {
                        ProductID = 1,
                        ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                        Price = 1993200,
                        PriceOld = 1399000,
                        Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",
                        },
                 new Product
                        {
                        ProductID = 2,
                        ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                        Price = 993200,
                        PriceOld = 1399000,
                        Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                         new Product
                   {
                    ProductID = 3,
                    ProductName = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"

                   },
                         new Product
                         {
                             ProductID=4,
                             ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                             Price=993200,
                             PriceOld=1399000,
                             Image="do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                         },
                         new Product
                         {
                             ProductID=5,
                             ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                              Price = 993200,
                               PriceOld = 1399000,
                                Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                         },
                         new Product
                   {
                     ProductID = 7,
                     ProductName = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                     Price = 993200,
                     PriceOld = 1399000,
                     Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"

                   }

            }





                },
                new Product
                {
                    ProductID=7,
                    ProductName = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                     Price = 993200,
                      Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg",
                      Tredemark="Lego (Đan Mạch)",
                      type = new List<Type>()
                      {
                          new Type
                          {
                              Nametype="Đồ chơi bé trai"
                          },
                          new Type
                          {
                              Nametype="Đồ chơi lắp ráp"
                          }
                      },
                      Age="4",
                      substance="Nhựa",
                      Boxsize="38x26x6 cm",
                      Weight="724 g",
                      Note="Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                      production="Trung Quốc",
                      Outstanding=new List<OutstandingFeatures>(){
                          new OutstandingFeatures
                          {
                              feature="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG bao gồm 241 chi tiết."
                          },
                          new OutstandingFeatures
                          {
                              feature="Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                          },
                          new OutstandingFeatures
                          {
                              feature="Đồ chơi Lego giúp bé rèn luyện tính tỉ mỉ, sáng tạo khi lắp ráp."
                          },
                          new OutstandingFeatures
                          {
                              feature="Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                          }

                      },
                      Manual=new List<Usermanual>()
                      {
                          new Usermanual
                          {
                              NameManual="Lắp ráp các khớp nối với nhau theo hình trên bao bì."

                          },
                          new Usermanual
                          {
                              NameManual="Có thể sáng tạo theo trí tưởng tượng của bé."
                          } 

                      },
                      OtherProduct=new List<Product>()
                      {
                           new Product
                        {
                        ProductID = 1,
                        ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                        Price = 1993200,
                        PriceOld = 1399000,
                        Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",
                        },
                           new Product
                        {
                        ProductID = 2,
                        ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                        Price = 993200,
                        PriceOld = 1399000,
                        Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                           new Product
                   {
                    ProductID = 3,
                    ProductName = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"

                   },
                           new Product
                         {
                             ProductID=4,
                             ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                             Price=993200,
                             PriceOld=1399000,
                             Image="do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                         },
                         new Product
                         {
                             ProductID=5,
                             ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                              Price = 993200,
                               PriceOld = 1399000,
                                Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                         },
                         new Product
                         {
                              ProductID=6,
                              ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                              Price=993200,
                              PriceOld=1399000,
                              Image="do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg",

                         }

                      }
                      


                }





            };
        }
    }
}





















