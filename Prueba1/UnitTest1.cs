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
            Lavadora lavadora1 = new Lavadora(2500, "Blanco", 'A', 15, 20); //
            Lavadora lavadora2 = new Lavadora(2500, "Blanco", 'B', 25, 35);
            Lavadora lavadora3 = new Lavadora(2500, "Blanco", 'C', 55, 15);
            Lavadora lavadora4 = new Lavadora(2500, "Blanco", 'D', 65, 50);
            Lavadora lavadora5 = new Lavadora(2500, "Blanco", 'E', 80, 10);
            Lavadora lavadora6 = new Lavadora(2500, "Blanco", 'F', 85, 66);

            Television tele1 = new Television(2500, "Blanco", 'A', 15, 20); //precio final sera 2610
            Television tele2 = new Television(2500, "Blanco", 'B', 25, 41); //precio final sera 3419
            Television tele3 = new Television(2500, "Blanco", 'C', 55, 50); //precio final sera 3432
            Television tele4 = new Television(2500, "Blanco", 'D', 65, 20); //precio final sera 2630
            Television tele5 = new Television(2500, "Blanco", 'E', 80, 10); //precio final sera 2610
            Television tele6 = new Television(2500, "Blanco", 'F', 85, 66); //precio final sera 3393

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








        }
    }
}

