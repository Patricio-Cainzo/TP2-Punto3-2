using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto3_2
{
    public class Lavadora : Electrodomestico
    {
        public int Carga { get; set; }

        public Lavadora()
        {
        }
        public Lavadora(double precio, int peso)
        {
            PrecioBase = precio;
            Peso = peso;
        }
        public Lavadora(double precio, string color, char consumo, int peso, int carga)
        {
            PrecioBase = precio;
            ColorElectrodomestico = color;
            Consumoenergetico = consumo;
            Peso = peso;
            Carga = carga;
        }
        //Consultar por la herencia de metodos , no me esta resultando.
        public override double PrecioFinal()
        {
            double precioBase = base.PrecioFinal();
            if (Carga > 30)
            {
                precioBase += 50;
            }

            return precioBase;
        }
    }
}
