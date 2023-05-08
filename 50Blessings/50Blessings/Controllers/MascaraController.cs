using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _50Blessings.Models;
using _50Blessings.Data;

namespace _50Blessings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascaraController : ControllerBase
    {
        public static List<Mascara> listaMascaras = new List<Mascara>();
        private readonly _50BlessingsContext _context;

        public MascaraController(_50BlessingsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Mascara> getMascara()
        {
            var lista = _context.Mascara.ToList();
            return lista;
        }

      
        [HttpPost]
        public string postMascara(Mascara novoMascara)
        {
            string teste = "Erro ao incluir Máscara";
            _context.Mascara.Add(novoMascara);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                teste = "Máscara incluida!";
            }
            return teste;
        }

        [HttpPut]
        public string putMascara(Mascara mascara)
        {
            string resultado = "Máscara não alterada!";
            _context.Mascara.Update(mascara);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Máscara alterada.";
            }
            return resultado;
        }

        [HttpDelete]
        public string deleteMascara(Mascara mascara)
        {
            string resultado = "Máscara não excluída!";
            _context.Mascara.Remove(mascara);
            var valor = _context.SaveChanges();
            if (valor == 1)
            {
                resultado = "Máscara excluída";
            }
            return resultado;
        }
    }
}
