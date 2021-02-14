using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, GalleryContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (GalleryContext context =new GalleryContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors on p.ColorId equals c.ColorId
                             join b in context.Brands on p.BrandId equals b.BrandId
                             select new CarDetailDto {CarId=p.CarId, ColorName=c.ColorName, BrandName=b.BrandName, ModelYear=p.ModelYear };
                return result.ToList();

            }

        }
    }
}
