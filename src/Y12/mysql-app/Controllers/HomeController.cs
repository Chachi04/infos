using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mysql_app.Models;
using MySql.Data.MySqlClient;

namespace mysql_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public String Get()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

        var configuration = builder.Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new MySqlCommand("insert into answers (answer) values (10);", connection))
            command.ExecuteNonQuery();
            /* { */
            /*     using (var reader = command.ExecuteReader()) */
            /*     { */
            /*         while (reader.Read()) */
            /*         { */
            /*             return reader.GetString(1); */
            /*         } */
            /*     } */
            /* } */
        }

        return "";
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
