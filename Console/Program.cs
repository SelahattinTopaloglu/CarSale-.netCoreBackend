using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            BrandTest();
            ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    System.Console.WriteLine(color.ColorName);
                }
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    System.Console.WriteLine(brand.BrandName);
                }
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }
    }
}
