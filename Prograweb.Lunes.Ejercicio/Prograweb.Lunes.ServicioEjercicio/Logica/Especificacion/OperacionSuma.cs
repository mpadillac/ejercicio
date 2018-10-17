using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Especificacion
{
    public class OperacionSuma
    {
        /// <summary>
        /// Función que devuelve la suma entre dos valores
        /// </summary>
        /// <param name="primernumero">el primer número de la operación</param>
        /// <param name="segundonumero">el segundo número de la operación</param>
        /// <returns>la suma entre ambos números</returns>

        public double Suma(double primernumero, double segundonumero)
        {
            var laAccion = new Prograweb.Lunes.ServicioEjercicio.Logica.Accion.OperacionSuma();
            double elResultado = laAccion.Suma(primernumero, segundonumero);
            return elResultado;
        }
    }
}