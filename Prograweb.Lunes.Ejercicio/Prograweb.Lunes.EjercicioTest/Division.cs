using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prograweb.Lunes.ServicioEjercicio.Logica;

namespace Prograweb.Lunes.EjercicioTest
{
    [TestClass]
    public class Division
    {
        [TestClass]
        public class Divisiones
        {
            [TestMethod]
            public void division()
            {
                // preparación del escenario
                var miprimernumero = 6.0;
                var misegundonumero = 3.0;
                var miValorEsperado = 2.0;
                var miValorReal = 0.0;

                // invocamos el método
                // para invocar dinámicamente al método
                var elServicio = new ServicioEjercicio.Logica.Servicio.Service1();
                miValorReal = elServicio.Division(miprimernumero, misegundonumero);

                // verificar el resultado obtenido
                Assert.AreEqual(miValorEsperado, miValorReal);




            }
        }
    }
}
