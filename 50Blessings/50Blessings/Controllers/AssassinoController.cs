using Microsoft.AspNetCore.Http;
using _50Blessings.Data;
using _50Blessings.Models;
using Microsoft.AspNetCore.Mvc;

namespace _50Blessings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssassinoController : ControllerBase
    {
        public static List<Assassino> listaAssassinos = new List<Assassino>();
        private readonly _50BlessingsContext _context;

        public AssassinoController(_50BlessingsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Assassino> getAssassino()
        {
            var lista = _context.Assassino.ToList();
            return lista;
        }


        [HttpPost]
        public string postAssassino(Assassino novoAssassino)
        {
            string teste = "Erro ao incluir Assassino";
            _context.Assassino.Add(novoAssassino);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                teste = "Assassino incluido!";
            }
            return teste;
        }

        [HttpPut]
        public string putAssassino(Assassino assassino)
        {
            string resultado = "Assassino não alterado!";
            _context.Assassino.Update(assassino);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Arma alterada.";
            }
            return resultado;
        }

        [HttpDelete]
        public string deleteAssassino(Assassino assassino)
        {
            string resultado = "Arma não excluída!";
            _context.Assassino.Remove(assassino);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Arma excluída";
            }
            return resultado;
        }
    }
}
