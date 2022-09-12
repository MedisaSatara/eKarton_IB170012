using ekarton.Databases;
using ekarton.Filters;
using ekarton.Security;
using ekarton.Services;
using Microsoft.AspNetCore.Authentication;
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
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ekarton
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
            services.AddControllers()
            .AddNewtonsoftJson(options =>
            options.SerializerSettings.ContractResolver =
            new CamelCasePropertyNamesContractResolver());
            //services.AddControllers();
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilter>();
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eKarton API", Version = "v1" });
                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });

            });

            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<rekartonContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers().AddNewtonsoftJson(options =>
                 options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IUlogaService, UlogaService>();
            services.AddScoped<IKorisnikUlogaService, KorisnikUlogaService>();
            services.AddScoped<IPacijentService, PacijentService>();
            services.AddScoped<IOsiguranjeService, OsiguranjeService>();
            services.AddScoped<IPacijentOsiguranjeService, PacijentOsiguranjeService>();
            services.AddScoped<IDoktorService, DoktorService>();
            services.AddScoped<IOdjelService, OdjelService>();
            services.AddScoped<IPreventivneMjereService, PreventivneMjereService>();
            services.AddScoped<ISistematskiPregledService, SistematskiPregledService>();
            services.AddScoped<INalazService, NalazService>();
            services.AddScoped<IPregledService, PregledService>();
            services.AddScoped<ITerapijaService, TerapijaService>();
            services.AddScoped<IUputnicaService, UputnicaService>();
            services.AddScoped<IOcjenaDoktoraService, OcjenaDoktoraService>();
            services.AddScoped<IRecommenderService, RecommenderService>();














        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
