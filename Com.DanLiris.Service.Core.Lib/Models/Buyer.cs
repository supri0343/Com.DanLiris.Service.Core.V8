using Com.DanLiris.Service.Core.Lib.Helpers;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.Moonlay.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Com.DanLiris.Service.Core.Lib.Models
{
    public class Buyer : StandardEntity, IValidatableObject
    {
        [MaxLength(255)]
         public string? UId { get; set; }

        [StringLength(100)]
         public string? Code { get; set; }

        [StringLength(500)]
         public string? Name { get; set; }

        [StringLength(3000)]
         public string? Address { get; set; }

        [StringLength(500)]
         public string? City { get; set; }

        [StringLength(500)]
         public string? Country { get; set; }

        [StringLength(500)]
         public string? Contact { get; set; }

        public int? Tempo { get; set; }

        [StringLength(500)]
         public string? Type { get; set; }

        [StringLength(100)]
         public string? NPWP { get; set; }

        [StringLength(100)]
         public string? NIK { get; set; }
        [StringLength(100)]
         public string? Job { get; set; }
        [StringLength(255)]
         public string? BuyerOwner { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> validationResult = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Code))
                validationResult.Add(new ValidationResult("Code is required", new List<string> { "code" }));

            if (string.IsNullOrWhiteSpace(this.Name))
                validationResult.Add(new ValidationResult("Name is required", new List<string> { "name" }));

            if (this.Tempo.Equals(null))
                this.Tempo = 0;
            else if (this.Tempo < 0)
                validationResult.Add(new ValidationResult("Tempo must be 0 or more", new List<string> { "tempo" }));

            if (string.IsNullOrWhiteSpace(this.Country))
                validationResult.Add(new ValidationResult("Country is required", new List<string> { "country" }));

            if (string.IsNullOrWhiteSpace(this.Type))
                validationResult.Add(new ValidationResult("Type is required", new List<string> { "type" }));

            if (validationResult.Count.Equals(0))
            {
                /* Service Validation */
                BuyerService service = (BuyerService)validationContext.GetService(typeof(BuyerService));

                if (service.DbContext.Set<Buyer>().Count(r => r._IsDeleted.Equals(false) && r.Id != this.Id && r.Code.Equals(this.Code)) > 0) /* Code Unique */
                    validationResult.Add(new ValidationResult("Code already exists", new List<string> { "code" }));
            }

            //if (string.IsNullOrEmpty(NIK))
            //    validationResult.Add(new ValidationResult("NIK is required", new List<string> { "nik" }));

            if (string.IsNullOrEmpty(Job))
                validationResult.Add(new ValidationResult("Job is required", new List<string> { "job" }));

            if (string.IsNullOrEmpty(BuyerOwner))
                validationResult.Add(new ValidationResult("Buyer Owner is required", new List<string> { "buyerOwner" }));

            return validationResult;
        }
    }
}
