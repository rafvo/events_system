using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        public IEnumerable<Event> _event = new Event[] {
            new Event() {
                Id = 1,
                Theme = "Angular 11 e .NET 5",
                Local = "Rio Preto",
                Batch = "1º Lote",
                AmountPeople = 250,
                Date = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageUrl = "photo.png"
            },
            new Event() {
                Id = 2,
                Theme = "Angular e suas novidades",
                Local = "São Paulo",
                Batch = "2º Lote",
                AmountPeople = 350,
                Date = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageUrl = "photo1.png"
            }
        };

        public EventController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(e => e.Id == id);
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}

//  private static readonly string[] Summaries = new[]
//         {
//             "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//         };

//         private readonly ILogger<EventoController> _logger;

// public EventoController(ILogger<EventoController> logger)
// {
//     _logger = logger;
// }

// [HttpGet]
// public IEnumerable<Evento> Get()
// {
//     var rng = new Random();

//     return Enumerable.Range(1, 5).Select(index => new Evento
//     {
//         Date = DateTime.Now.AddDays(index),
//         TemperatureC = rng.Next(-20, 55),
//         Summary = Summaries[rng.Next(Summaries.Length)]
//     })
//     .ToArray();
// }
