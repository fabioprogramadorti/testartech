using Microsoft.AspNetCore.Mvc;

namespace LocalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocalController : ControllerBase
    {
        private readonly List<Local> _locais = new List<Local>
        {
            new Local { Nome = "Farmácia São Paulo", Endereco = "Rua São Paulo, 123", Horario = "09:00-18:00" },
            new Local { Nome = "Padaria do João", Endereco = "Avenida João, 456", Horario = "07:00-15:00" },
            new Local { Nome = "Barbearia do Zé", Endereco = "Rua do Zé, 789", Horario = "10:00-19:00" },
            new Local { Nome = "Supermercado Extra", Endereco = "Rua do Extra, 321", Horario = "08:00-22:00" },
            new Local { Nome = "Confeitaria da Maria", Endereco = "Avenida Maria, 654", Horario = "09:00-20:00" },
            new Local { Nome = "Cinema Cinemark", Endereco = "Shopping Center, Sala 1", Horario = "13:00-22:00" },
            new Local { Nome = "Academia BodyFit", Endereco = "Rua da Academia, 10", Horario = "06:00-23:00" },
            new Local { Nome = "Loja de Roupas", Endereco = "Rua das Roupas, 432", Horario = "10:00-20:00" },
            new Local { Nome = "Posto de Gasolina Shell", Endereco = "Avenida da Gasolina, 987", Horario = "24h" },
            new Local { Nome = "Restaurante Italiano", Endereco = "Rua da Massa, 567", Horario = "12:00-15:00, 19:00-23:00" }
        };

        [HttpGet]
        public IEnumerable<Local> Get()
        {
            var now = DateTime.Now.TimeOfDay;
            return _locais.Where(l => l.Horario.Contains("10:00-13:00") && TimeSpan.Parse(l.Horario.Split("-")[0]) <= now && now <= TimeSpan.Parse(l.Horario.Split("-")[1]));
        }
    }

    public class Local
    {
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Horario { get; set; }
    }
}
