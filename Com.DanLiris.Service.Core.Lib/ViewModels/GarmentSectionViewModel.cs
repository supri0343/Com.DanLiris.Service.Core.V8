﻿using Com.DanLiris.Service.Core.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Core.Lib.ViewModels
{
    public class GarmentSectionViewModel : BasicViewModel
    {
         public string? Code { get; set; }
         public string? Name { get; set; }
         public string? Remark { get; set; }
         public string? ApprovalCC { get; set; }
         public string? ApprovalRO { get; set; }
         public string? ApprovalKadiv { get; set; }
    }
}
