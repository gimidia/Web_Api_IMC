using Microsoft.AspNetCore.Mvc;
using System;

namespace Web_Api_IMC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMCController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "olá tudo bem";
        }

        //POST api/valores
        [HttpPost("/valores")]
        public string Post(float peso, float altura)
        {
            var imc = (peso / (altura * altura));
            if (imc <= 18.5)
            {
                Console.WriteLine("Peso abaixo do normal");
                return "Peso abaixo do normal";
            }
            else if ((imc > 18.5) && (imc < 25))
            {
                Console.WriteLine("Peso normal");
                return "Peso normal";
            }
            else if ((imc >= 25) && (imc < 30))
            {
                Console.WriteLine("Sobre o Peso");
                return $"Sobre o Peso";
            }
            else if ((imc >= 30) && (imc < 35))
            {
                Console.WriteLine("Grau de Obesidade I");
                return "Grau de Obesidade I";
            }
            else if ((imc >= 35) && (imc < 40))
            {
                Console.WriteLine("Grau de Obesidade II");
                return "Grau de Obesidade II";
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade Grau III");
                return "Obesidade Grau III";
            }
            //return Created($"api/valores/{peso},{altura}", imc);
            return null;
        }
    }
}
