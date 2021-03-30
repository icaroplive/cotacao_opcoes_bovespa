using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using carteiraAcoes.Entity;
using carteiraAcoes.Interfaces;
using carteiraAcoes.Interfaces.Task;
using carteiraAcoes.Services;
using carteiraAcoes.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Hangfire;
using Hangfire.MySql.Core;
using carteiraAcoes.Interfaces.InfoMoney;

namespace carteiraAcoes {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            JobStorage.Current = new MySqlStorage(Configuration.GetConnectionString("DefaultConnection"));

            services.AddDbContext<BancoContext> (options => options.UseLazyLoadingProxies ().UseMySql (Configuration.GetConnectionString ("DefaultConnection")));
            

            services.AddHangfire(config =>
                config.UseStorage(new MySqlStorage(Configuration.GetConnectionString("DefaultConnection")))
             );

            services.AddHangfireServer();

            //RecurringJob.AddOrUpdate<AcaoTask> ("sincronizarAcoes",t => t.sincronizarAcoes() ,  "*/15 * * * *");
           // RecurringJob.AddOrUpdate<AcaoTask> ("sincronizarOpcoes",t => t.sincronizarOpcoes() ,  "*/16 * * * *");
            //RecurringJob.AddOrUpdate<InfoMoneyService> ("infomoney",t => t.pegarOpcoes("COGN3") ,  "*/15 * * * *");

            services.AddTransient<ILucroService, LucroService> ();

            services.AddTransient<IAcaoService, AcaoService> ();

            services.AddTransient<IOpcaoService, OpcoesService> ();
            
            services.AddTransient<IAcaoTask, AcaoTask> ();

            services.AddTransient<IInfoMoneyService, InfoMoneyService> ();
            
            services.AddCors (options => {
                options.AddPolicy ("CorsPolicy",
                    builder => builder.AllowAnyOrigin ()
                    .AllowAnyMethod ()
                    .AllowAnyHeader ());
            });
            services
   .AddControllers()
   .AddJsonOptions(options =>
   {
       options.JsonSerializerOptions.IgnoreNullValues = true;
   })
   .AddNewtonsoftJson(options =>
   {
       options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
   });
         //   services.AddControllers ();


            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }
            app.UseHangfireDashboard();
            //app.UseHangfireServer();
            app.UseCors ("CorsPolicy");
            //app.UseHttpsRedirection ();

            app.UseRouting ();

            app.UseAuthorization ();

            app.UseEndpoints (endpoints => {
                endpoints.MapControllers ();
            });
    
        }
    }
}