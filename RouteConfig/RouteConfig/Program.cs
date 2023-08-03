

using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute( 
    name:"default",
    Pattern: "{controller=Home}/{action=Index}/{id?}"
    
    );

app.Run();
