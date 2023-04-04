using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajos_Progra_5to_ciclo
{
    class Espada:Armas
    {
        public string Nombre;
        public int Daño;
        public float AtSpd;
        public float Precio;

        public Espada(string nombre,int daño, float atSpd,float price)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.AtSpd = atSpd;
            this.Precio = price;
        }
        public override void Stats()
        {
            Console.WriteLine("Nombre" + Nombre);
            Console.WriteLine("Daño" + Daño);
            Console.WriteLine("AtSpd" + AtSpd);
            Console.WriteLine("Precio" + Precio);

            int a = Convert.ToInt32(Daño / AtSpd);
            Console.WriteLine("DPS" + a);
        }

    }
}
