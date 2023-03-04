using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ex_21._02.Models;
using MySql.Data.MySqlClient;

namespace ex_21._02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private string conString = "server=localhost;userid=chachi;database=guess_the_number";


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

    public IActionResult ViewResult(string username, string password, int guess)
    {
        bool auth = false;
        int user_id = 0;
        using(MySqlConnection con = new MySqlConnection(conString))
        {
            con.Open();
            using(var query = new MySqlCommand("select * from users;", con))
            {
                using(var reader = query.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if(username == reader["username"].ToString() && password == reader["password"].ToString())
                        {
                            user_id = (int)reader["id"];
                            auth = true;
                        }
                    }
                }
            }
        }

        if(!auth)
        {
            ViewBag.error = "Invalid username or password";
            return View("Index");
        }

        int num = generateNum();
        InsertToDB(conString, $"insert into guesses (user_id,guess, answer, is_correct) values({user_id},{guess},{num},{guess==num})");
        ViewBag.guess = guess;
        ViewBag.answer = num;
        ViewBag.is_correct = guess == num;
        return View();
    }

    public IActionResult ViewStatistics()
    {
        int guessCount = 0;
        ViewBag.guesses = new List<Dictionary<string, string>>();
        ViewBag.correctness = 0;
        using(MySqlConnection con = new MySqlConnection(conString))
        {
            con.Open();
            using(var query = new MySqlCommand("select * from guesses;", con))
            {
                using(var reader = query.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        ViewBag.guesses.Add(new Dictionary<string, string>{
                            {"id", reader["id"].ToString()},
                            {"guess", reader["guess"].ToString()},
                            {"answer", reader["answer"].ToString()},
                            {"is_correct", reader["is_correct"].ToString()}
                        });
                        ViewBag.correctness += (bool)reader["is_correct"] == true ? 1 : 0;
                        guessCount++;
                    }
                }
            }
        }
        ViewBag.correctness = Math.Round((double)ViewBag.correctness/guessCount, 2);

        return View();
    }

    private void InsertToDB(string conString, string queryString){
        using(MySqlConnection con = new MySqlConnection(conString))
        {
            con.Open();
            using(var query = new MySqlCommand(queryString, con)){
                query.ExecuteNonQuery();
            }
        }
    }


    private int generateNum(){
        Random rnd = new Random();
        return rnd.Next(1, 10);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
