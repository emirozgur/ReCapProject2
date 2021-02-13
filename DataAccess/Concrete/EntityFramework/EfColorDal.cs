using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (GalleryContext context = new GalleryContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (GalleryContext context = new GalleryContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (GalleryContext context = new GalleryContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (GalleryContext context = new GalleryContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (GalleryContext context = new GalleryContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        //public void Add(Color entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Color entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Color Get(Expression<Func<Color, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Color entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
