﻿using Com.DanLiris.Service.Core.Lib.Helpers;
using System;

namespace Com.DanLiris.Service.Core.Lib.ViewModels
{
    public class BuyerViewModel : BasicViewModel
    {
         public string? Code { get; set; }
        
         public string? Name { get; set; }
        
         public string? Address { get; set; }
        
         public string? City { get; set; }
        
         public string? Country { get; set; }
        
         public string? Contact { get; set; }

        /* Int */
        public dynamic Tempo { get; set; }
        
         public string? Type { get; set; }
        
         public string? NPWP { get; set; }
         public string? NIK { get; set; }

         public string? Job { get; set; }

         public string? BuyerOwner { get; set; }
    }
}
