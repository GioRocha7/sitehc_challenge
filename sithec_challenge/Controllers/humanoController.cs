using Microsoft.AspNetCore.Mvc;
using sithec_challenge.Models;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace sithec_challenge.Controllers
{
    [ApiController]
    [Route("humano")]
    public class humanoController : ControllerBase
    {
          List<Humano> humanos = new List<Humano>()
            {
                new Humano
                {
                    id = 1,
                    Nombre = "Giovanni Rocha",
                    Sexo = "Masculino",
                    Edad = 27,
                    Altura = "1.78",
                    Peso = 95
                },
                 new Humano
                 {
                     id = 2,
                     Nombre = "luis Carrizales",
                     Sexo = "Masculino",
                     Edad = 27,
                     Altura = "1.78",
                     Peso = 95
                 },

            };
        [HttpGet]
        [Route("/listar")]
        public dynamic listarHumano()
        {
            
            return humanos;
        }
        [HttpGet]
        [Route("/listarxid")]
        public dynamic listarHumanoId(int _id)
        {
            Console.WriteLine("listar por id:"+_id);
            var response = humanos.Find(humano => humano.id == _id);
            Console.WriteLine(response);
            if(response == null) {
               return new { Message = "humano no encontrado" };
            }
            else
            {
                return response;

            }


        }
        [HttpPost]
        [Route("/guardar")]
        public dynamic guardarHumano(Humano humano)
        {
            humano.id = 3;
            

            humanos.Add(new Humano
            {
                id = humano.id,
                Nombre = humano.Nombre,
                Sexo = humano.Sexo,
                Edad = humano.Edad,
                Altura = humano.Altura,
                Peso = humano.Peso
            });

            return new
            {
                success=true,
                message="humano registrado",
                result= humanos
            };
        }
        [HttpDelete]
        [Route("/eliminar")]
        public dynamic eliminarHumano(int _id)
        {
            

            return new
            {
                success = true,
                message = "humano eliminado",
                result = humanos
            };
        }

        [HttpPut]
        [Route("/editar")]
        public dynamic editarHumano(Humano humano)
        {
            Console.WriteLine(humano.id);
            var response = humanos.Find(h => h.id == humano.id);
            if (response == null)
            {
                return new { Message = "humano no encontrado" };
            }
            else
            {
                humanos.Remove(response);
                humanos.Add(new Humano
                {
                    id = humano.id,
                    Nombre = humano.Nombre,
                    Sexo = humano.Sexo,
                    Edad = humano.Edad,
                    Altura = humano.Altura,
                    Peso = humano.Peso
                });
               
                return new
                {
                    success = true,
                    message = "humano editado",
                    result = humanos
                };

            }
            
        }
    }
}
