using Microsoft.AspNetCore.Mvc;

namespace Rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("meuNome")]
        public string getNome()
        {
            return "João";
        }

        [HttpGet]
        [Route("minhaIdade")]
        public string getIdade()
        {
            return "Minha idade é 21 anos";
        }

        [HttpGet]
        [Route("recebeNome/{nome}")]
        public string getRecebe([FromRoute] string nome)
        {
            return nome;
        }

        [HttpPost]
        [Route("nomeIdade")]
        public string getNomeIdade(string nome, int idade)
        {
            if(idade >= 18)
            {
                return nome + " é maior de idade";
            }
            else
            {
                return nome + " é menor de idade";
            }
            
        }
    }
    
}
