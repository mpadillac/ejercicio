using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prograweb.Lunes.EjercicioTest
{
    [TestClass]
    public class Suma
    {
        [TestClass]
        public class Sumas
        {
            [TestMethod]
            public void Suma()
            {
                // preparación del escenario
                var miprimernumero = 6.0;
                var misegundonumero = 3.0;
                var miValorEsperado = 9.0;
                var miValorReal = 0.0;

                // invocamos el método
                // para invocar dinámicamente al método
                var elServicio = new ServicioEjercicio.Logica.Servicio.Service1();
                miValorReal = elServicio.Suma(miprimernumero, misegundonumero);

                // verificar el resultado obtenido
                Assert.AreEqual(miValorEsperado, miValorReal);




            }
        }
    }
}
