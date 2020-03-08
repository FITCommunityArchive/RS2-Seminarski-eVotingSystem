
using AutoMapper;
using eVotingSystem.API.Helpers;
using eVotingSystem.DAL.EF;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.Services;
using eVotingSystem.WebAPI.Helpers;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle;
using System.Collections.Generic;
using System.Reflection;

namespace eVotingSystem.WebAPI
{
    //public class BasicAuthDocumentFilter : IDocumentFilter
    //{
    //    public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
    //    {
    //        var securityRequirements = new Dictionary<string, IEnumerable<string>>()
    //    {
    //        { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
    //    };

    //        swaggerDoc.Security = new[] { securityRequirements };
    //    }
    //}
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(eVotingSystem.CORE.Helpers.Mapper).Assembly);

            services.AddDbContext<eVotingSystemDbContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("eVotingSystem"), b => b.MigrationsAssembly("eVotingSystem.WebAPI")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "My API", Version = "v1" });
                c.CustomSchemaIds((type) => type.FullName);
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<ICandidateService, CandidateService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IElectionCycleService, ElectionCycleService>();
            services.AddScoped<IElectionCycleElectiveListService, ElectionCycleElectiveListService>();
            services.AddScoped<IElectionOptionService, ElectionOptionService>();
            services.AddScoped<IElectionRegionService, ElectionRegionService>();
            services.AddScoped<IElectionUnitService, ElectionUnitService>();
            services.AddScoped<IElectiveListService, ElectiveListService>();
            services.AddScoped<IElectiveListElectionOptionService, ElectiveListElectionOptionService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<INationalityService, NationalityService>();
            services.AddScoped<IPoliticalOrganizationService, PoliticalOrganizationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVoteService, VoteService>();
            services.AddScoped<IVoterService, VoterService>();

            //services.AddControllers();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
            app.UseMvc();
        }
    }
}
