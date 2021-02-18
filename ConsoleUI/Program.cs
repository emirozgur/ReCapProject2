using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
//using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //Burada colortest ve brandTest metodlarında bu var getall kullanılmasıına rağmen tek değer getiriyor araştırılacak.
            //ColorTest();
            //BrandTest();
            //CarJoinTest();

            //CarAdd();
            //BrandAdd();
            //ColorAdd();

            //CarUpdate();
            //ColorUpdate();
            //BrandUpdate();

            //CarDelete();
            //ColorDelete();
            //BrandDelete();
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 4, ColorId = 4, ModelYear = "2016", DailyPrice = 130, Description = "Vasat" });
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color { ColorName = "Smoked" });
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { BrandName = "Honda" });
        }
        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId=4, BrandId = 5, ColorId = 5, ModelYear = "2015", DailyPrice = 140, Description = "Vasattan iyi" });
        }

        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Update(new Color { ColorId=1002, ColorName = "Metallic" });
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Update(new Brand {BrandId=1002, BrandName = "Suzuki" });
        }
        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId=4});
        }

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Delete(new Color { ColorId = 1002 });
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Delete(new Brand { BrandId = 1002 });
        }


        private static void CarJoinTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.ModelYear + "/" + car.BrandName + "/" + car.ColorName);
            }
            Console.ReadLine();
        }

            private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);

            }
            Console.ReadLine();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);

            }
            Console.ReadLine();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.ReadLine();
        }
    }
}
