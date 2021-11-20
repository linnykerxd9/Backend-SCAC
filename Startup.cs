using Backend_SCAC.src.Repositories;
using Backend_SCAC.src.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC
{
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
            var connect = Configuration.GetSection("ConnectionStrings:DefaultConnection");
            services.AddDbContext<Repository>(options => options.UseSqlServer(connect.Value));

            services.AddScoped<Repository, Repository>();
            services.AddScoped<ServiceEvent, ServiceEvent>();
            services.AddScoped<ServiceCommunityLeader, ServiceCommunityLeader>();
            services.AddScoped<ServiceOrgPublic, ServiceOrgPublic>();
            services.AddScoped<ServicePriority, ServicePriority>();
            services.AddScoped<ServiceResident, ServiceResident>();
            services.AddScoped<ServiceStatus, ServiceStatus>();
            services.AddScoped<ServiceVindication, ServiceVindication>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Backend_SCAC", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend_SCAC v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
