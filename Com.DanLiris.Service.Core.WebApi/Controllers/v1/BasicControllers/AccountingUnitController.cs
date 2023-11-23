﻿using Com.DanLiris.Service.Core.Lib.Helpers.IdentityService;
using Com.DanLiris.Service.Core.Lib.Helpers.ValidateService;
using Com.DanLiris.Service.Core.Lib.Models;
using Com.DanLiris.Service.Core.Lib.Services.AccountingUnit;
using Com.Danliris.Service.Core.WebApi.Utils;
using Com.Moonlay.NetCore.Lib.Service;
using CsvHelper;
using CsvHelper.TypeConversion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Com.Danliris.Service.Core.WebApi.Utils;
using General = Com.Danliris.Service.Core.WebApi.Helpers.General;
using Com.DanLiris.Service.Core.Lib.Helpers;
using System.Globalization;


namespace Com.DanLiris.Service.Core.WebApi.Controllers.v1.BasicControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/accounting-units")]
    //[Authorize]
    public class AccountingUnitController : Controller
    {
        private const string ContentType = "application/vnd.openxmlformats";
        private readonly string FileName = string.Concat("Error Log - ", typeof(AccountingUnit).Name, " ", DateTime.Now.ToString("dd MMM yyyy"), ".csv");
        private const string ApiVersion = "1.0.0";
        private readonly IIdentityService _identityService;
        private readonly IValidateService _validateService;
        private readonly IAccountingUnitService _service;

        public AccountingUnitController(IServiceProvider serviceProvider)
        {
            _identityService = serviceProvider.GetService<IIdentityService>();
            _validateService = serviceProvider.GetService<IValidateService>();
            _service = serviceProvider.GetService<IAccountingUnitService>();
        }

        private void VerifyUser()
        {
            _identityService.Username = User.Claims.ToArray().SingleOrDefault(p => p.Type.Equals("username")).Value;
            _identityService.Token = Request.Headers["Authorization"].FirstOrDefault().Replace("Bearer ", "");
            _identityService.TimezoneOffset = Convert.ToInt32(Request.Headers["x-timezone-offset"]);
        }

        [HttpGet]
        public IActionResult Get(int page = 1, int size = 25, string order = "{}", [Bind(Prefix = "Select[]")] List<string> select = null, string keyword = null, string filter = "{}")
        {
            try
            {
                var result = _service.ReadModel(page, size, order, select, keyword, filter);

                var response =
                    new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE).Ok(null, result.Data, page, size, result.Count, result.Data.Count, result.Order, result.Selected);
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message).Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, response);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AccountingUnit model)
        {
            try
            {
                VerifyUser();
                _validateService.Validate(model);

                await _service.CreateModel(model);

                var response = new ResultFormatter(ApiVersion, General.CREATED_STATUS_CODE, General.OK_MESSAGE).Ok();
                return Created(string.Concat(Request.Path, "/", 0), response);
            }
            catch (ServiceValidationException e)
            {
                var response = new ResultFormatter(ApiVersion, General.BAD_REQUEST_STATUS_CODE, General.BAD_REQUEST_MESSAGE).Fail(e);
                return BadRequest(response);
            }
            catch (Exception e)
            {
                var response = new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message).Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, response);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            try
            {
                var model = await _service.ReadModelById(id);

                if (model == null)
                {
                    var response = new ResultFormatter(ApiVersion, General.NOT_FOUND_STATUS_CODE, General.NOT_FOUND_MESSAGE).Fail();
                    return NotFound(response);
                }
                else
                {
                    var response = new ResultFormatter(ApiVersion, General.OK_STATUS_CODE, General.OK_MESSAGE).Ok(null, model);
                    return Ok(response);
                }
            }
            catch (Exception e)
            {
                var response = new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message).Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, response);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] AccountingUnit model)
        {
            try
            {
                VerifyUser();
                _validateService.Validate(model);

                if (id != model.Id)
                {
                    var response = new ResultFormatter(ApiVersion, General.BAD_REQUEST_STATUS_CODE, General.BAD_REQUEST_MESSAGE).Fail();
                    return BadRequest(response);
                }

                await _service.UpdateModel(id, model);

                return NoContent();
            }
            catch (ServiceValidationException e)
            {
                var response = new ResultFormatter(ApiVersion, General.BAD_REQUEST_STATUS_CODE, General.BAD_REQUEST_MESSAGE).Fail(e);
                return BadRequest(response);
            }
            catch (Exception e)
            {
                var response = new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message).Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, response);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                VerifyUser();
                var model = await _service.ReadModelById(id);

                if (model == null)
                {
                    var response = new ResultFormatter(ApiVersion, General.NOT_FOUND_STATUS_CODE, General.NOT_FOUND_MESSAGE).Fail();
                    return NotFound(response);
                }
                else
                {
                    await _service.DeleteModel(id);
                    return NoContent();
                }
            }
            catch (Exception e)
            {
                Dictionary<string, object> Result =
                    new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message)
                    .Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, Result);
            }
        }

        [HttpPost("upload")]
        public async Task<IActionResult> PostCSVFileAsync()
        {
            try
            {
                if (Request.Form.Files.Count > 0)
                {
                    VerifyUser();
                    var uploadedFile = Request.Form.Files[0];
                    var reader = new StreamReader(uploadedFile.OpenReadStream());
                    var fileHeader = new List<string>(reader.ReadLine().Split(","));
                    var validHeader = _service.CsvHeader.SequenceEqual(fileHeader, StringComparer.OrdinalIgnoreCase);

                    if (validHeader)
                    {
                        reader.DiscardBufferedData();
                        reader.BaseStream.Seek(0, SeekOrigin.Begin);
                        reader.BaseStream.Position = 0;
                        var csv = new CsvReader(reader,CultureInfo.InvariantCulture);
                        //csv.Configuration.IgnoreQuotes = false;
                        //csv.Configuration.Delimiter = ",";
                        //csv.Configuration.RegisterClassMap<AccountingUnitMap>();
                        //csv.Configuration.HeaderValidated = null;

                        var data = csv.GetRecords<AccountingUnit>().ToList();

                        Tuple<bool, List<object>> Validated = _service.UploadValidate(data, Request.Form.ToList());

                        reader.Close();

                        if (Validated.Item1) /* If Data Valid */
                        {
                            await _service.UploadData(data);

                            var response = new ResultFormatter(ApiVersion, General.CREATED_STATUS_CODE, General.OK_MESSAGE).Ok();
                            return Created(HttpContext.Request.Path, response);

                        }
                        else
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                using (var streamWriter = new StreamWriter(memoryStream))
                                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                                {
                                    csvWriter.WriteRecords(Validated.Item2);
                                }

                                return File(memoryStream.ToArray(), ContentType, FileName);
                            }
                        }
                    }
                    else
                    {
                        var response = new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, General.CSV_ERROR_MESSAGE).Fail();

                        return NotFound(response);
                    }
                }
                else
                {
                    var response = new ResultFormatter(ApiVersion, General.BAD_REQUEST_STATUS_CODE, General.NO_FILE_ERROR_MESSAGE).Fail();
                    return BadRequest(response);
                }
            }
            catch (TypeConverterException ex)
            {
                var response = new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, "Rate diisi huruf\n" + ex.Message).Fail();
                return StatusCode((int)HttpStatusCode.InternalServerError, response);
            }
            catch (Exception e)
            {
                var response = new ResultFormatter(ApiVersion, General.INTERNAL_ERROR_STATUS_CODE, e.Message).Fail();
                return StatusCode(General.INTERNAL_ERROR_STATUS_CODE, response);
            }
        }
    }
}
