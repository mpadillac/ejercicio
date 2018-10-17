using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Especificacion
{
    public class OperacionDivision
    {
        /// <summary>
        /// Función que devuelve la división entre dos valores
        /// </summary>
        /// <param name="primernumero">el primer número de la operación</param>
        /// <param name="segundonumero">el segundo número de la operación</param>
        /// <returns>la división entre ambos números</returns>

        public double Division(double primernumero, double segundonumero)
        {
            var laAccion = new Prograweb.Lunes.ServicioEjercicio.Logica.Accion.OperacionDivision();
            double elResultado = laAccion.Division(primernumero, segundonumero);
            return elResultado;
        }
    }
}