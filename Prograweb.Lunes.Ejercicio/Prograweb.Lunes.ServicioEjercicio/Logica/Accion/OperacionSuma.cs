using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Accion
{
    public class OperacionSuma
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Suma(double primernumero, double segundonumero)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.OperacionSuma();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(primernumero, segundonumero))
                elResultado = primernumero + segundonumero;
            else
                MiListaDeErrores.Add("nada");
            return elResultado;
        }
    }
}