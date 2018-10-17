using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Validacion
{
    public class OperacionSuma
    {
        public bool LosOperadoresSonCorrectos(double primernumero, double segundonumero)
        {
            bool elResultado = true;
            // valido que los valores de los parámetros no arrojen un error matemático

            //elResultado = !(segundonumero == 0);
            return elResultado;
        }
    }
}