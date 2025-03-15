namespace WebApplication2
{
    public class Program
    {
        public static async void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/bato", () => "Hello World!");
            app.MapGet("/{name}",   async context =>

            { 
                var Name = context.GetRouteValue("name");
                await context.Response.WriteAsync($"Hello {Name}");
            });
            app.Run();
        }
    }
}
