﻿using Com.DanLiris.Service.Core.Lib;
using Com.DanLiris.Service.Core.Lib.Models;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.DanLiris.Service.Core.Lib.ViewModels;
using Com.Danliris.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/material-constructions")]
    public class MaterialConstructionController : BasicController<MaterialConstructionService, MaterialConstruction, MaterialConstructionViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
        public MaterialConstructionController(MaterialConstructionService service) : base(service, ApiVersion)
        {
        }
    }
}
