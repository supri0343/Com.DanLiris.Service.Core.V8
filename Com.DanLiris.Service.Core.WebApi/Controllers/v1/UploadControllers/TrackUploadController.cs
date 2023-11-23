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

namespace Com.DanLiris.Service.Core.WebApi.Controllers.v1.UploadControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/upload-track")]
    public class TrackUploadController : BasicUploadController<TrackService, TrackModel, TrackViewModel, TrackService.TrackMap, CoreDbContext>
    {
        private static readonly string ApiVersion = "1.0";
        public TrackUploadController(TrackService service) : base(service, ApiVersion)
        {
        }
    }
}
