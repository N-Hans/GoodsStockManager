using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStockManager.API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GoodsStockManager
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
            services.AddDbContext<GoodsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("GoodsDatabase")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseDefaultFiles(new DefaultFilesOptions() { DefaultFileNames = new[] { "index.html" } });
            app.MapWhen(context =>
            {
                var path = context.Request.Path.Value.ToLower();
                return path.Contains("/") && !path.Contains(".js") && !path.Contains("/api/") &&
                       !path.Contains(".ico");
            },
            branch =>
            {
                branch.Use((context, next) =>
                {
                    context.Request.Path = new PathString("/index.html");
                    return next();
                });

                branch.UseStaticFiles();
            });
            app.UseMvc();
        }
    }
}
