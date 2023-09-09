using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Punto3_2
{
    public enum Color
    {
        Blanco,
        Negro,
        Rojo,
        Azul,
        Verde
    }
    public enum Consumodeenergia
    {
        A,
        B,
        C,
        D,
        E,
        F
    }
    public abstract class Electrodomestico
    {
        public double PrecioBase { get; set; }
        public string ColorElectrodomestico { get; set; }
        public char Consumoenergetico { get; set; }
        public double Peso { get; set; }

        public bool Validarconsumoenergetico()
        {
            return Enum.IsDefined(typeof(Consumodeenergia), Consumoenergetico);
        }
        public bool Validarcolor()
        {
            return Enum.IsDefined(typeof(Color), ColorElectrodomestico);
        }
        public virtual double PrecioFinal()
        {
            int precioConsumo = 0;
            int preciopeso = 0;

            if (Consumoenergetico == 'A')
            {
                precioConsumo = 100;
            }
            else if (Consumoenergetico == 'B')
            {
                precioConsumo = 80;
            }
            else if (Consumoenergetico == 'C')
            {
                precioConsumo = 60;
            }
            else if (Consumoenergetico == 'D')
            {
                precioConsumo = 50;
            }
            else if (Consumoenergetico == 'E')
            {
                precioConsumo = 30;
            }
            else if (Consumoenergetico == 'F')
            {
                precioConsumo = 10;
            }

            if (Peso >= 0 && Peso <= 19)
            {
                preciopeso = 10;
            }
            else if (Peso >= 20 && Peso <= 49)
            {
                preciopeso = 50;
            }
            else if (Peso >= 50 && Peso <= 80)
            {
                preciopeso = 80;
            }
            else if (Peso > 80)
            {
                preciopeso = 100;
            }


            return preciopeso + precioConsumo;

        }
    }

}