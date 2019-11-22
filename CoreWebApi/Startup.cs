using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
using CoreWebApi.Models.DataManager;
using CoreWebApi.Models.Repository;

namespace CoreWebApi
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
            services.AddDbContext<MoodFullContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:MoodFullDB"]));
            services.AddScoped<IDataRepository<User>, UserManager>();
            services.AddScoped<IDataRepository<Restaurant>, RestaurantManager>();
            services.AddScoped<IDataRepository<Evaluation>, EvaluationManager>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
