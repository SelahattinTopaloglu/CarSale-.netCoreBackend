using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarSaleContext>, ICarDal

    {
        public List<CarDetailDto> GetCarDetails()
        {
            //database 3 tablo joinli
            using (CarSaleContext context = new CarSaleContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarId equals b.BrandId
                             join co in context.Colors
                             on c.CarId equals co.ColorId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, CarName = c.CarName, ColorName = co.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
