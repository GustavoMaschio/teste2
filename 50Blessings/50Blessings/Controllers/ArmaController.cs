using Microsoft.AspNetCore.Http;
using _50Blessings.Data;
using _50Blessings.Models;
using Microsoft.AspNetCore.Mvc;

namespace _50Blessings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmaController : ControllerBase
    {
        public static List<Arma> listaArmas = new List<Arma>();
        private readonly _50BlessingsContext _context;

        public ArmaController(_50BlessingsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Arma> getArma()
        {
            var lista = _context.Arma.ToList();
            return lista;
        }


        [HttpPost]
        public string postArma(Arma novoArma)
        {
            string teste = "Erro ao incluir Arma";
            _context.Arma.Add(novoArma);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                teste = "Arma incluida!";
            }
            return teste;
        }

        [HttpPut]
        public string putArma(Arma arma)
        {
            string resultado = "Arma não alterada!";
            _context.Arma.Update(arma);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Arma alterada.";
            }
            return resultado;
        }

        [HttpDelete]
        public string deleteArma(Arma arma)
        {
            string resultado = "Arma não excluída!";
            _context.Arma.Remove(arma);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Arma excluída";
            }
            return resultado;
        }
    }
}