using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public string BrandName { get; set; }
        public string ColorName { get; set; }
       
    }
}
