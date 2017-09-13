using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using menuAppBLL;
using menuAppBLL.BusinessObjects;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MovieRestAPI
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
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                var facade = new BLLFacade();
                facade.MovieServices.Create(new MovieBO()
                    {
                        VideoName = "Harry Potter",
                        Genre = "sci-fi"
                    }
                    );
                facade.MovieServices.Create(new MovieBO()
                    {
                        VideoName = "Lord of the rings",
                        Genre = "Adventure"
                    }
                );

                facade.RentalServices.Create(new RentalBO()
                    {
                        DeliveryDate = DateTime.Now.AddMonths(1),
                        OrderDate = DateTime.Now.AddMonths(-1)
                    }
                );
            }

            app.UseMvc();
        }
    }
}
