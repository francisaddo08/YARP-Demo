namespace YARP.As.Migration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddReverseProxy()
            .LoadFromConfig(builder.Configuration.GetSection("YARP"));
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
             app.MapReverseProxy();
            app.Run();
        }
    }
}
