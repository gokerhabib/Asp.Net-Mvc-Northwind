﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcNorthwind.Entities;

namespace AspNetMvcNorthwind.Interfaces
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAll();
        [OperationContract]
        Category Get(int categoryId);
    }
}
