﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Especificacion
{
    public class OperacionMultilica
    {
        /// <summary>
        /// Función que devuelve la Multiplicación entre dos valores
        /// </summary>
        /// <param name="primernumero">el primer número de la operación</param>
        /// <param name="segundonumero">el segundo número de la operación</param>
        /// <returns>la multiplicación entre ambos números</returns>

        public double Multiplica(double primernumero, double segundonumero)
        {
            var laAccion = new Prograweb.Lunes.ServicioEjercicio.Logica.Accion.OperacionMultiplica();
            double elResultado = laAccion.Multiplica(primernumero, segundonumero);
            return elResultado;
        }
    }
}