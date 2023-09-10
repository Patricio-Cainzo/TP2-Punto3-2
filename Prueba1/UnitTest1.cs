using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TP2_Punto3_2;

namespace Prueba1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrenge
            Lavadora lavadora1 = new Lavadora(2500, "Blanco", 'A', 15, 20); //precio final 2610
            Lavadora lavadora2 = new Lavadora(2500, "Negro", 'B', 25, 35); //precio final 2680
            Lavadora lavadora3 = new Lavadora(2500, "Rojo", 'C', 55, 15); //precio final 2640
            Lavadora lavadora4 = new Lavadora(2500, "Azul", 'D', 65, 50); //precio final 2680
            Lavadora lavadora5 = new Lavadora(2500, "Verde", 'E', 80, 10); //precio final 2610
            Lavadora lavadora6 = new Lavadora(2500, "Marron", 'F', 85, 66); //precio final 2660

            Television tele1 = new Television(2500, "Rojo", 'A', 15, 20); //precio final sera 2610
            Television tele2 = new Television(2500, "Rosa", 'B', 25, 41); //precio final sera 3419
            Television tele3 = new Television(2500, "Negro", 'C', 55, 50); //precio final sera 3432
            Television tele4 = new Television(2500, "Azul", 'D', 65, 20); //precio final sera 2630
            Television tele5 = new Television(2500, "Blanco", 'E', 80, 10); //precio final sera 2610
            Television tele6 = new Television(2500, "Morado", 'F', 85, 66); //precio final sera 3393
            Television tele7 = new Television(2500, "Morado", 'J', 85, 66); //solo lo uso para probar el consumo energetico
            Television tele8 = new Television(2500, "Morado", 'N', 85, 66); //solo lo uso para probar el consumo energetico
            Television tele9 = new Television(2500, "Morado", 'L', 85, 66); //solo lo uso para probar el consumo energetico

            //act 
            double preciotele1 = tele1.PrecioFinal();
            double preciotele2 = tele2.PrecioFinal();
            double preciotele3 = tele3.PrecioFinal();
            double preciotele4 = tele4.PrecioFinal();
            double preciotele5 = tele5.PrecioFinal();
            double preciotele6 = tele6.PrecioFinal();
            double preciolavadora1 = lavadora1.PrecioFinal();
            double preciolavadora2 = lavadora2.PrecioFinal();
            double preciolavadora3 = lavadora3.PrecioFinal();
            double preciolavadora4 = lavadora4.PrecioFinal();
            double preciolavadora5 = lavadora5.PrecioFinal();
            double preciolavadora6 = lavadora6.PrecioFinal();
            

            //assert 
            Assert.AreEqual(2610, preciotele1);
            Assert.AreEqual(3419, preciotele2);
            Assert.AreEqual(3432, preciotele3);
            Assert.AreEqual(2630, preciotele4);
            Assert.AreEqual(2610, preciotele5);
            Assert.AreEqual(3393, preciotele6);
            Assert.AreEqual(2610, preciolavadora1);
            Assert.AreEqual(2680, preciolavadora2);
            Assert.AreEqual(2640, preciolavadora3);
            Assert.AreEqual(2680, preciolavadora4);
            Assert.AreEqual(2610, preciolavadora5);
            Assert.AreEqual(2660, preciolavadora6);
            Assert.IsTrue(tele1.Validarcolor());
            Assert.IsFalse(tele2.Validarcolor());
            Assert.IsTrue(tele3.Validarcolor());
            Assert.IsTrue(tele4.Validarcolor());
            Assert.IsTrue(tele5.Validarcolor());
            Assert.IsFalse(tele6.Validarcolor());
            Assert.IsTrue(lavadora1.Validarcolor());
            Assert.IsTrue(lavadora2.Validarcolor());
            Assert.IsTrue(lavadora3.Validarcolor());
            Assert.IsTrue(lavadora4.Validarcolor());
            Assert.IsTrue(lavadora5.Validarcolor());
            Assert.IsFalse(lavadora6.Validarcolor());
            Assert.IsTrue(tele1.Validarconsumoenergetico());
            Assert.IsTrue(tele2.Validarconsumoenergetico());
            Assert.IsTrue(tele3.Validarconsumoenergetico());
            Assert.IsTrue(tele4.Validarconsumoenergetico());
            Assert.IsTrue(tele5.Validarconsumoenergetico());
            Assert.IsTrue(tele6.Validarconsumoenergetico());
            Assert.IsFalse(tele7.Validarconsumoenergetico());
            Assert.IsFalse(tele8.Validarconsumoenergetico());
            Assert.IsFalse(tele9.Validarconsumoenergetico());
            Assert.IsTrue(lavadora1.Validarconsumoenergetico());



        }
    }
}

