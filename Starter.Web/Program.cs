namespace Starter.Web
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);
      builder.Services.AddControllers();
      builder.Services.AddSpaStaticFiles(configuration => configuration.RootPath = "ClientApp/dist");

      var app = builder.Build();
      app.UseSpaStaticFiles();
      app.UseHttpsRedirection();
      app.MapControllers();
      app.UseRouting();
      app.UseAuthorization();
      app.UseEndpoints(builder => builder.MapDefaultControllerRoute());
      app.UseSpa(spa =>
      {
        spa.Options.SourcePath = Path.Combine(builder.Environment.ContentRootPath, "ClientApp");
        if (builder.Environment.IsDevelopment())
        {
          spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
        }
      });

      app.Run();
    }
  }
}
