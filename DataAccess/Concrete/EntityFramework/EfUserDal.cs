using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, GalleryContext>, IUserDal
    {
        // Burada user tablosu ile diğer tabloların join kodları olacak
        public List<UserDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
