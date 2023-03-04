using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using forms.Models;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;


namespace forms.Controllers;

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

    public IActionResult Page1()
    {
        return View();
    }

    public String Page2()
    {
        string response = "";
        String conString = @"server=localhost;userid=chachi@localhost;password=;database=guess_the_number";

        using(MySqlConnection con = new MySqlConnection(conString))
        {

            MySqlCommand cmd = new MySqlCommand("insert into answers values(1)", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            int affectedRows = cmd.ExecuteNonQuery();

            /* MySqlCommand cmd2 = new MySqlCommand("select * from answers)", con); */
            /* cmd2.CommandType = System.Data.CommandType.Text; */
            /* MySqlDataReader result = cmd2.ExecuteReader(); */
            /*  */
            /* while(result.Read()) */
            /* { */
            /*     int id = (int)result[0]; */
            /*     int answer = (int)result[1]; */
            /*  */
            /*     id = (int)result["id"]; */
            /*     answer = (int)result["answer"]; */
            /*  */
            /*     response += $"id: {id}, answer: {answer}"; */
            /* } */

        }

        return response;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
