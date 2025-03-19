using Microsoft.AspNetCore.Routing.Constraints;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            // app.MapGet("/", () => "Hello World!");
            // app.MapGet("/index", () => "Hello from index");
            app.UseStaticFiles();
            app.MapControllerRoute
                (name: "default",
                pattern: "{Controller=Home}/{Action=Index}/{Id:int?}"// id is optional {Id:regex(^\\d{{2}}$)?}
                                                               // defaults: new { action = "Index", controller = "Movies" },
                                                               //constraints: new {Id= new IntRouteConstraint()}
                // constraints: new { Id = @"\d{2}" }
                ); 

            // app.MapGet("/bato", () => "Hello World!");
            // app.MapGet("/{name}",   async context =>
            //  app.MapGet("/x{name}",   async context =>


            //{
            // var Name = context.GetRouteValue("name");
            //  await context.Response.WriteAsync($"Hello {Name}");
            //    await context.Response.WriteAsync($"Hello {context.Request.RouteValues["name"]}");


            //});
            app.Run();
        }
    }
}
