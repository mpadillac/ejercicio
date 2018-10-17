using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prograweb.Lunes.EjercicioTest
{
    [TestClass]
    public class Multiplica
    {
        [TestMethod]
        public void multiplica()
        {
            // preparación del escenario
            var miprimernumero = 6.0;
            var misegundonumero = 3.0;
            var miValorEsperado = 18.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new ServicioEjercicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Multiplica(miprimernumero, misegundonumero);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);




        }
    }
}
