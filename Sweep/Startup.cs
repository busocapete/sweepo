using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using GolfSweep.Repositories;
using AutoMapper;
using GolfSweep.Dtos;

namespace GolfSweep
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));


            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {
                //config.SignIn.RequireConfirmedEmail = true;
                //config.SecurityStampValidationInterval = TimeSpan.FromMinutes(15);
            })
                .AddDefaultUI(UIFramework.Bootstrap4)
                //.AddClaimsPrincipalFactory<MyUserClaimsPrincipalFactory>()
                .AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                // options.Password.RequiredUniqueChars = 6;

                // Lockout settings  
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                //options.Lockout.MaxFailedAccessAttempts = 10;
                //options.Lockout.AllowedForNewUsers = true;

                // User settings  
                options.User.RequireUniqueEmail = true;
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IEntryRepository, EntryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IHandicapRepository, HandicapRepository>();
            services.AddScoped<IOOMPointsRepository, OOMPointsRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IScoreCardRepository, ScoreCardRepository>();
            services.AddScoped<IScoreRepository, ScoreRepository>();
            services.AddScoped<ISweepRepository, SweepRepository>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                //// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();

                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();


            }

            using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.Migrate();
            }

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Event, EventDto>().ReverseMap();
                cfg.CreateMap<Entry, EntryDto>();
                cfg.CreateMap<ScoreCard, ScoreCardDto>();
                cfg.CreateMap<Player, PlayerDto>();
                cfg.CreateMap<Score, ScoreDto>().ReverseMap();
                cfg.CreateMap<Course, CourseDto>().ReverseMap();
                cfg.CreateMap<OOMPoints, OOMPointsDto>().ReverseMap();
                cfg.CreateMap<Event, PlayerEventDto>().ReverseMap();
                cfg.CreateMap<SweepPlayer, SweepEntryDto>().ReverseMap();
                cfg.CreateMap<OOMPoints, OOMForLeaderBoardDto>().ReverseMap();
                cfg.CreateMap<SweepPlayer, SweepApprovalDto>().ReverseMap();
                cfg.CreateMap<Data.Sweep, SweepDto>().ReverseMap();
            });

            //Mapper.Initialize(c => c.AddProfile<AutoMapperProfile>());

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //routes.MapSpaFallbackRoute(
                //    name: "spa-fallback",
                //    defaults: new { controller = "Home", action = "Index" });

            });
        }
    }
}
