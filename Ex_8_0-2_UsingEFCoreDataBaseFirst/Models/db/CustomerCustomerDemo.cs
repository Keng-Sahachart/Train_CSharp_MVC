﻿using System;
using System.Collections.Generic;

namespace Ex_8_0_UsingEFCoreDataBaseFirst.models.db
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
