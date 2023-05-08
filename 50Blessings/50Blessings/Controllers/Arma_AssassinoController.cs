using Microsoft.AspNetCore.Http;
using _50Blessings.Data;
using _50Blessings.Models;
using Microsoft.AspNetCore.Mvc;

namespace _50Blessings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Arma_AssassinoController : ControllerBase
    {
        public static List<Arma_Assassino> listaArma_Assassino = new List<Arma_Assassino>();
        private readonly _50BlessingsContext _context;

        public Arma_AssassinoController(_50BlessingsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Arma_Assassino> getArma_Assassino()
        {
            var lista = _context.Arma_Assassino.ToList();
            return lista;
        }


        [HttpPost]
        public string postArma_Assassino(Arma_Assassino novoArma_Assassino)
        {
            string teste = "Erro ao incluir Arma_Assassino";
            _context.Arma_Assassino.Add(novoArma_Assassino);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                teste = "Arma incluida!";
            }
            return teste;
        }

        [HttpPut]
        public string putArma_Assassino(Arma_Assassino arma_assassino)
        {
            string resultado = "Arma_Assassino não alterada!";
            _context.Arma_Assassino.Update(arma_assassino);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Arma_Assassino alterada.";
            }
            return resultado;
        }

        [HttpDelete]
        public string deleteArma_Assassino(Arma_Assassino arma_assassino)
        {
            string resultado = "Arma_Assassino não excluída!";
            _context.Arma_Assassino.Remove(arma_assassino);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Arma_Assassino excluída";
            }
            return resultado;
        }
    }
}