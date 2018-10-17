using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Accion
{
    public class OperacionMultiplica
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Multiplica(double primernumero, double segundonumero)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.OperacionMultiplica();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(primernumero, segundonumero))
                elResultado = primernumero * segundonumero;
            else
                MiListaDeErrores.Add("Nada");
            return elResultado;
        }
    }
}