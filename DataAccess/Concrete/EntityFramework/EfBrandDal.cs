﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        //public void Add(Brand entity)
        //{
        //    using (GalleryContext context =new GalleryContext())
        //    {
        //        var addedEntity = context.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Brand entity)
        //{
        //    using (GalleryContext context=new GalleryContext())
        //    {
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public Brand Get(Expression<Func<Brand, bool>> filter)
        //{
        //    using (GalleryContext context =new GalleryContext())
        //    {
        //        return context.Set<Brand>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        //{
        //    using (GalleryContext context= new GalleryContext())
        //    {
        //        return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList(); 
        //    }
        //}

        //public void Update(Brand entity)
        //{
        //    using (GalleryContext context=new GalleryContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
