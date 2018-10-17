using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Prograweb.Lunes.ServicioEjercicio.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

        /// <summary>
        /// Formula que devuelve la división de dos números
        /// </summary>
        /// <param name="primernumero">primer número de la división</param>
        /// <param name="segundonumero">segundo número de la división</param>
        /// <returns>devuelve el resultado de la división entre esos dos números</returns>
        public double Division(double primernumero, double segundonumero)
        {
            // forma 1
            //var laEspecificacion = new Logica.Especificacion.OperacionPotencia();
            // forma 2
            Logica.Especificacion.OperacionDivision laEspecificacion;
            laEspecificacion = new Logica.Especificacion.OperacionDivision();
            var elResultado = laEspecificacion.Division(primernumero, segundonumero);
            return elResultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if(composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
