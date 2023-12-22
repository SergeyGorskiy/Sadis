using Sadis.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureSqlServerContext(builder.Configuration);
builder.Services.AddControllersWithViews();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Operator}/{controller=Home}/{action=Index}/{id?}");

app.Run();
