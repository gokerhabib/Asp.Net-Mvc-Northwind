﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();

        Category Get(int categoryId);
    }
}
