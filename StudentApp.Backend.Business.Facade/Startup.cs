using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StudentApp.Backend.Business.Logic;
using StudentApp.Backend.Business.Logic.Contracts;
using StudentApp.Backend.Common.Logic;
using StudentApp.Backend.Common.Logic.Contracts;
using StudentApp.Backend.Repository.Logic;
using StudentApp.Backend.Repository.Logic.Contracts;
using StudentApp.Backend.Repository.Logic.DataBaseContexts;

namespace StudentApp.Backend.Business.Facade
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
            services.AddDbContext<StudentContext>();
            services.AddTransient<IMyLog, Log4NetLogger>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IBusinessLogic, BusinessLogic>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
