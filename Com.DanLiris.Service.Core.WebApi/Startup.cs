using Com.DanLiris.Service.Core.Lib;
using Com.DanLiris.Service.Core.Lib.Helpers.IdentityService;
using Com.DanLiris.Service.Core.Lib.Helpers.ValidateService;
using Com.DanLiris.Service.Core.Lib.Services.GarmentEMKL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using System.Text;
using System.Text.Json;
using Com.DanLiris.Service.Core.Lib.Services;
using Com.DanLiris.Service.Core.Lib.Services.Account_and_Roles;
using Com.DanLiris.Service.Core.Lib.Services.MachineSpinning;
using Com.DanLiris.Service.Core.Lib.Services.GarmentLeftoverWarehouseBuyer;
using Com.DanLiris.Service.Core.Lib.Services.GarmentShippingStaff;
using Com.DanLiris.Service.Core.Lib.Services.GarmentFabricType;
using Com.DanLiris.Service.Core.Lib.Services.GarmentForwarder;
using Com.DanLiris.Service.Core.Lib.Services.GarmentTransactionType;
using Com.DanLiris.Service.Core.Lib.Services.GarmentLeftoverWarehouseProduct;
using Com.DanLiris.Service.Core.Lib.Services.GarmentLeftoverWarehouseComodity;
using Com.DanLiris.Service.Core.Lib.Services.GarmentCourier;
using Com.DanLiris.Service.Core.Lib.Services.GarmentInsurance;
using Com.DanLiris.Service.Core.Lib.Services.GarmentWareHouse;
using Com.DanLiris.Service.Core.Lib.Services.GarmentMarketing;
using Com.DanLiris.Service.Core.Lib.Services.BankCashReceiptType;
using Com.DanLiris.Service.Core.Lib.Services.IBCurrency;
using Com.DanLiris.Service.Core.Lib.Services.GarmentAdditionalCharges;
using Com.DanLiris.Service.Core.Lib.Services.BudgetingCategory;
using Com.DanLiris.Service.Core.Lib.Services.AccountingUnit;
using Com.DanLiris.Service.Core.Lib.Services.AccountingCategory;
using Com.DanLiris.Service.Core.Lib.Services.BICurrency;

namespace Com.Danliris.Service.Core.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private void RegisterServices(IServiceCollection services)
        {
            services
                .AddScoped<IIdentityService, IdentityService>()
                .AddScoped<IValidateService, ValidateService>();

          
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection") ?? Configuration["DefaultConnection"];
            string authority = Configuration["Authority"];
            string clientId = Configuration["ClientId"];
            string secret = Configuration["Secret"];

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services
                .AddDbContext<CoreDbContext>(options => options.UseSqlServer(connectionString))
                .AddScoped<AccountBankService>()
                //.AddScoped<AccountService>()
                .AddScoped<DesignMotiveService>()
                .AddScoped<BudgetService>()
                .AddScoped<BuyerService>()
                .AddScoped<CategoryService>()
                .AddScoped<CurrencyService>()
                .AddScoped<DivisionService>()
                .AddScoped<DesignMotiveService>()
                .AddScoped<GarmentCurrencyService>()
                .AddScoped<GarmentDetailCurrencyService>()
                .AddScoped<BudgetCurrencyService>()
                .AddScoped<GarmentBuyerService>()
                .AddScoped<GarmentComodityService>()
                .AddScoped<HolidayService>()
                .AddScoped<ProductService>()
                .AddScoped<StorageService>()
                .AddScoped<SupplierService>()
                .AddScoped<TermOfPaymentService>()
                .AddScoped<UnitService>()
                .AddScoped<UomService>()
                .AddScoped<IncomeTaxService>()
                .AddScoped<QualityService>()
                .AddScoped<ComodityService>()
                .AddScoped<OrderTypeService>()
                .AddScoped<YarnMaterialService>()
                .AddScoped<MaterialConstructionService>()
                .AddScoped<ProcessTypeService>()
                .AddScoped<FinishTypeService>()
                .AddScoped<StandardTestsService>()
                .AddScoped<LampStandardService>()
                .AddScoped<PermissionService>()
                .AddScoped<ColorTypeService>()
                .AddScoped<RolesService>()
                .AddScoped<GarmentProductService>()
                .AddScoped<GarmentCategoryService>()
                .AddScoped<GarmentSupplierService>()
                .AddScoped<GarmentUnitService>()
                .AddScoped<GarmentSampleUnitService>()
                .AddScoped<GarmentBuyerBrandService>()
                .AddScoped<GarmentSectionService>()
                .AddScoped<StandardMinuteValueService>()
                .AddTransient<IMachineSpinningService, MachineSpinningService>()
                .AddTransient<IGarmentLeftoverWarehouseBuyerService, GarmentLeftoverWarehouseBuyerService>()
                .AddTransient<IGarmentShippingStaffService, GarmentShipingStaffService>()
                .AddTransient<IGarmentFabricTypeService, GarmentFabricTypeService>()
                .AddTransient<IGarmentEMKLService, GarmentEMKLService>()
                .AddTransient<IGarmentForwarderService, GarmentForwarderService>()
                .AddTransient<IGarmentTransactionTypeService, GarmentTransactionTypeService>()
                .AddTransient<IGarmentLeftoverWarehouseProductService, GarmentLeftoverWarehouseProductService>()
                .AddTransient<IGarmentLeftoverWarehouseComodityService, GarmentLeftoverWarehouseComodityService>()
                .AddTransient<IGarmentCourierService, GarmentCourierService>()
                .AddTransient<IGarmentInsuranceService, GarmentInsuranceService>()
                .AddTransient<IBICurrencyService, BICurrencyService>()
                .AddTransient<IAccountingCategoryService, AccountingCategoryService>()
                .AddTransient<IAccountingUnitService, AccountingUnitService>()
                .AddTransient<IBudgetingCategoryService, BudgetingCategoryService>()
                .AddTransient<IGarmentAdditionalChargesService, GarmentAdditionalChargesService>()
                .AddTransient<IIBCurrencyService, IBCurrencyService>()
                .AddTransient<IBankCashReceiptTypeService, BankCashReceiptTypeService>()
                .AddScoped<RolesService>()
                .AddScoped<SizeService>()
                .AddScoped<VatService>()
                .AddScoped<ProductTypeService>()
                .AddTransient<IGarmentWareHouseService, GarmentWareHouseService>()
                .AddScoped<ProductTextileService>()
                .AddScoped<MenuService>()
                .AddTransient<IGarmentMarketingService, GarmentMarketingService>()
                .AddScoped<TrackService>()
                .AddScoped<DebitCreditNoteService>();

            RegisterServices(services);

            services
                .AddApiVersioning(options =>
                {
                    options.ReportApiVersions = true;
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.DefaultApiVersion = new ApiVersion(1, 1);
                });

            //services.AddSingleton<IMongoClient, MongoClient>(
            //    _ => new MongoClient(Configuration.GetConnectionString("MongoConnection") ?? Configuration["MongoConnection"]));

            #region Authenticatio
            string Secret = Configuration.GetValue<string>("Secret") ?? Configuration["Secret"];
            SymmetricSecurityKey Key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Secret));

            services.
                AddAuthentication(options => /*JwtBearerDefaults.AuthenticationScheme*/
                {
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

                })
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    //options.SaveToken = true;
                    //options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false,
                        ValidateIssuer = false,
                        ValidateLifetime = false,
                        IssuerSigningKey = Key,
                        ValidateIssuerSigningKey = true,
                    };
                });

            #endregion

            //services.AddDistributedRedisCache(options =>
            //{
            //    options.Configuration = Configuration.GetValue<string>("RedisConnection") ?? Configuration["RedisConnection"];
            //    options.InstanceName = Configuration.GetValue<string>("RedisConnectionName") ?? Configuration["RedisConnectionName"];
            //});

            services.AddCors(o => o.AddPolicy("CorePolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithExposedHeaders("Content-Disposition", "api-version", "content-length", "content-md5", "content-type", "date", "request-id", "response-time");
            }));



            /* API */

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });

            services
                .AddMvcCore()
                .AddApiExplorer()
                .AddAuthorization();

            services.AddControllers()
            //.AddJsonOptions(opt =>
            //{
            //    opt.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            //    //opt.JsonSerializerOptions
            //})
            .AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    var context = serviceScope.ServiceProvider.GetService<CoreDbContext>();
            //    context.Database.SetCommandTimeout(1000 * 60 * 10);
            //    context.Database.Migrate();
            //}

            app.UseAuthentication();
            app.UseCors("CorePolicy");

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

        }


    }
}
