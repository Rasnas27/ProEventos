using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
public IEnumerable<Evento> _evento = new Evento[] { 
    new Evento(){
        EventoId = 1,
        Tema = "Angular 11 e Dotnet 5",
        Local = "Brasília",
        Lote = "Primeiro lote",
        QtdPessoas = 250,
        DataEvento = DateTime.Now.AddDays(2).ToString()
        },
    new Evento(){
        EventoId = 2,
        Tema = "Angular 12 e Dotnet 5",
        Local = "Belo Horizonte",
        Lote = "Segundo lote",
        QtdPessoas = 150,
        DataEvento = DateTime.Now.AddDays(2).ToString()
}};

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public IEnumerable<Evento> Post()
        {
            return _evento;
        }
        
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Valor put id = {id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Valor delete id = {id}";
        }
    }
}
