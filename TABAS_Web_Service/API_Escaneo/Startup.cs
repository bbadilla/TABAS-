using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Escaneo.Logic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace API_Escaneo
{
    //public class Startup
    //{
    //    public Startup(IHostingEnvironment env)
    //    {
    //        var builder = new ConfigurationBuilder()
    //             .SetBasePath(env.ContentRootPath)
    //             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    //             .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
    //             .AddEnvironmentVariables();

    //        Configuration = builder.Build();
    //    }

    //    public IConfiguration Configuration { get; }

    //    // This method gets called by the runtime. Use this method to add services to the container.
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //        services.AddMvc();
    //        services.AddSingleton<I_User, Conf_User>();
    //        services.AddSingleton<I_Maleta, Conf_Maleta>();
    //        services.AddSwaggerGen(c =>
    //        {
    //            c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
    //        });

    //    }

    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app)
    //    {
    //        app.UseSwagger();
    //        app.UseSwaggerUI(c =>
    //        {
    //            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    //        });
    //        app.UseMvc();
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
            services.AddSingleton<I_User, Conf_User>();
            services.AddSingleton<I_Maleta, Conf_Maleta>();
            //services.AddSingleton<I_Maleta, Conf_Maleta>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

        }
    }
}
