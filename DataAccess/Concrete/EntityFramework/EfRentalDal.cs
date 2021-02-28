using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, GalleryContext>, IRentalDal
    {
        // Burada rental tablosu ile diğer tabloların join kodları olacak
        public List<RentalDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
