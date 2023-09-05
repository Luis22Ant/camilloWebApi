using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Aluno> Get()
    {
        return new Aluno[]
        {
        new() {Matricula=1,Nome="Ana"},
        new() {Matricula=2,Nome="Bruno"},
        new() {Matricula=3,Nome="Carlos"}
        };

    }

    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; } = "";
    }
}
