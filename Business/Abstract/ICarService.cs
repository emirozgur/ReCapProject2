﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        //List<Car> GetCarsByCarId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarByDailyPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
    }
}
