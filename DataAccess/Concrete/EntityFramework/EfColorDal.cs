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
    public class EfColorDal : EfEntityRepositoryBase<Color, GalleryContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            // Burada color tablosu ile diğer tabloların join kodları olacak
            throw new NotImplementedException();
        }
    }
}
