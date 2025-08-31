namespace MVC01;
    public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        #region ConfigureServices
        //builder.Services.Add<>()
        #endregion

        //builder.Build();

        app.MapGet("/", () => "Hello World!");
        app.Run();
        //this version is >NET 7 so maybe its like that and will upgrade to .NET 9

        //upgraded to .NET 9 and i dont see anyy difference
    }
}