using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Repositories.Abstract;
using WebApplication2.Repositories.Concrete;
using WebApplication2.Services;
using WebApplication2.Services.Abstract;
using WebApplication2.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
        
    }
);

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddTransient<IHashtagService, HashtagService>();
builder.Services.AddTransient<IHashtagRepository, HashtagRepository>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);
builder.Services.Configure<IdentityOptions>(options =>
{
    ////password settings
    //options.Password.RequireDigit= true;
    //options.Password.RequireNonAlphanumeric= true;
    //options.Password.RequireLowercase= true;
    //options.Password.RequireUppercase= true;
    //options.Password.RequiredLength = 6;
    //options.Password.RequiredUniqueChars = 1;
    ////lockout settings
    //options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5);
    //options.Lockout.MaxFailedAccessAttempts= 5;
    ////User Settings
    options.User.RequireUniqueEmail= true;
    //options.User.AllowedUserNameCharacters = "abc";

});

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("IsAdmin", policy => policy.RequireClaim("IsAdmin", "true"));
    //options.AddPolicy("IsAdmin", policy => policy.RequireRole("admin"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "areaRoute",
    pattern: "{area:exists}/{controller}/{action}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
