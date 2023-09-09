using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto3_2
{
    public class Television : Electrodomestico
    {
        public int Pulgadas;

        public Television()
        {
        }
        public Television(int pulgadas)
        {
            Pulgadas = pulgadas;
        }
        public Television(int precio, string color, char consumo, int peso, int pulgadas)
        {
            PrecioBase = precio;
            ColorElectrodomestico = color;
            Consumoenergetico = consumo;
            Peso = peso;
            Pulgadas = pulgadas;
        }

        public override double PrecioFinal()
        {
            double preciotele = base.PrecioFinal();
            double precioadevolver = 0;
            if (Pulgadas > 40)
            {
                precioadevolver = preciotele + (preciotele * 0.30);
            }

            return precioadevolver;
        }
    }

}