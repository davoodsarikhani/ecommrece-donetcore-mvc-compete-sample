﻿using eTicket.Data.Base;
using eTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(AppDbContext context):base(context)
        {

        }
    }
}
