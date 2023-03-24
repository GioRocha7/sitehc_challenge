using Microsoft.AspNetCore.Mvc;
using sithec_challenge.Models;

namespace sithec_challenge.Controllers
{
    [ApiController]
    [Route("Operacion")]
    public class operacionesController:ControllerBase
    {
        [HttpPost]
        [Route("/Suma")]
        public dynamic suma(Operaciones datos)
        {
            int resultado = 0;

            resultado=datos.A+datos.B+datos.C;

          

            return new
            {
                success = true,
                message = "El resultado de la suma es :"+resultado,
                
            };
        }
        [HttpPost]
        [Route("/Resta")]
        public dynamic resta(Operaciones datos)
        {
            int resultado = 0;

            resultado = datos.A - datos.B - datos.C;



            return new
            {
                success = true,
                message = "El resultado de la resta es :" + resultado,

            };
        }
        [HttpPost]
        [Route("/Multiplicacion")]
        public dynamic multiplicacion(Operaciones datos)
        {
            int resultado = 0;

            resultado = datos.A * datos.B * datos.C;



            return new
            {
                success = true,
                message = "El resultado de la Multiplicacion es :" + resultado,

            };
        }
        [HttpPost]
        [Route("/Divicion")]
        public dynamic Divicion(Operaciones datos)
        {
            double resultado = 0;

            resultado = datos.A / datos.B / datos.C;



            return new
            {
                success = true,
                message = "El resultado de la divicion es :" + resultado,

            };
        }
        [HttpPost]
        [Route("/operacionesPost")]
        public dynamic operacionesGet(Operaciones datos)
        {
            int resultado_s = 0;
            int resultado_r = 0;
            int resultado_m = 0;
            double resultado_d = 0;

            resultado_s = datos.A + datos.B + datos.C;
            resultado_r = datos.A - datos.B - datos.C;
            resultado_m = datos.A * datos.B * datos.C;
            resultado_d = datos.A / datos.B / datos.C;



            return new
            {
                success = true,
                msg_suma = "El resultado de la suma es :" + resultado_s,
                msg_resta = "El resultado de la resta es :" + resultado_r,
                msg_multiplicacion = "El resultado de la multiplicacion es :" + resultado_m,
                msg_divicion = "El resultado de la divicion es :" + resultado_d,

            };

        }
        [HttpGet]
        [Route("/operacionesGet")]
        public dynamic operacionesGet(int _A,int _B , int _C)
        {
            int resultado_s = 0;
            int resultado_r = 0;
            int resultado_m = 0;
            double resultado_d = 0;

            resultado_s = _A + _B + _C;
            resultado_r = _A - _B - _C;
            resultado_m = _A * _B * _C;
            resultado_d = _A / _B / _C;



            return new
            {
                success = true,
                msg_suma = "El resultado de la suma es :" + resultado_s,
                msg_resta = "El resultado de la resta es :" + resultado_r,
                msg_multiplicacion = "El resultado de la multiplicacion es :" + resultado_m,
                msg_divicion = "El resultado de la divicion es :" + resultado_d,

            };

        }
    }
}
