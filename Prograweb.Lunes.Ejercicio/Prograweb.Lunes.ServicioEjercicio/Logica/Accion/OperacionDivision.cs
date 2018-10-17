using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Accion
{
    public class OperacionDivision
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Division(double primernumero, double segundonumero)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.OperacionDivision();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(primernumero, segundonumero))
                elResultado = primernumero / segundonumero;
            else
                MiListaDeErrores.Add("No se puede dividir entre 0.");
            return elResultado;
        }
    }
}