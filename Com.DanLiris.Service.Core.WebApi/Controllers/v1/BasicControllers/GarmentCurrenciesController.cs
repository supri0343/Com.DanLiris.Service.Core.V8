﻿using Com.DanLiris.Service.Core.Lib;
using Com.DanLiris.Service.Core.Lib.Models;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.DanLiris.Service.Core.Lib.ViewModels;
using Com.Danliris.Service.Core.WebApi.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Com.DanLiris.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/garment-currencies")]
    public class GarmentCurrenciesController : BasicController<GarmentCurrencyService, GarmentCurrency, GarmentCurrencyViewModel, CoreDbContext>
    {
        private new static readonly string ApiVersion = "1.0";
		GarmentCurrencyService service;

        public GarmentCurrenciesController(GarmentCurrencyService service) : base(service, ApiVersion)
		{
			this.service = service;
		}

		[HttpGet("byId")]
		public IActionResult GetByIds([Bind(Prefix = "garmentCurrencyList[]")]List<int> garmentCurrencyList)
		{
			try
			{
				service.Username = User.Claims.Single(p => p.Type.Equals("username")).Value;

				List<GarmentCurrency> Data = service.GetByIds(garmentCurrencyList);

				Dictionary<string, object> Result =
					new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
					.Ok(Data);

				return Ok(Result);
			}
			catch (Exception e)
			{
				Dictionary<string, object> Result =
					new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
					.Fail();
				return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
			}
		}

        [HttpGet("byCode/{code}")]
        public IActionResult GetByCode([FromRoute] string code)
        {
            try
            {
                List<GarmentCurrency> Data = service.GetByCode(code);

                Dictionary<string, object> Result =
                     new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                     .Ok(Data);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }

        [HttpGet("single-by-code/{code}")]
        public IActionResult GetSingleByCode([FromRoute] string code)
        {
            try
            {
                var Data = service.GetSingleByCode(code);

                if (Data == null)
                    throw new Exception("Not Found");

                Dictionary<string, object> Result =
                     new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                     .Ok(Data);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }

        [HttpGet("single-by-code-date")]
        public IActionResult GetSingleByCodeDate([FromQuery] string code, [FromQuery] string stringDate)
        {
            try
            {
                var date = DateTimeOffset.Parse(stringDate);
                var Data = service.GetSingleByCodeDate(code, date);

                if (Data == null)
                    throw new Exception("Not Found");

                Dictionary<string, object> Result =
                     new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                     .Ok(Data);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }

        [HttpGet("by-code-before-date")]
        public IActionResult GetByCodeBeforeDate([FromBody] List<GarmentCurrencyViewModel> filters)
        {
            try
            {
                List<GarmentCurrencyViewModel> Data = service.GetByCodeBeforeDate(filters);

                Dictionary<string, object> Result =
                     new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                     .Ok(Data);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }

        [HttpGet("by-before-date")]
        public IActionResult GetByCodeAfterDate(int page = 1, int size = 25, string keyword = "", string filter = "{}")
        {
            try
            {
                List<GarmentCurrency> Data = service.GetByDate(page, size, keyword, filter);

                Dictionary<string, object> Result =
                     new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                     .Ok(Data);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }

        [HttpGet("sales-debtor-currencies")]
        public IActionResult GetRate()
        {
            try
            {
                 
                var Data = service.GetRate();

                if (Data == null)
                    throw new Exception("Not Found");

                Dictionary<string, object> Result =
                     new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                     .Ok(Data);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }

        [HttpGet("sales-debtor-currencies-peb")]
        public IActionResult GetRatePEB( [FromQuery] string stringDate)
        {
            try
            {
                var date = DateTimeOffset.Parse(stringDate);
                var Data = service.GetRatePEB(date);

                if (Data == null)
                    throw new Exception("Not Found");

                Dictionary<string, object> Result =
                     new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE)
                     .Ok(Data);

                return Ok(Result);
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }
    }
}
