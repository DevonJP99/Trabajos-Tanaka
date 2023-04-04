using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajos_Progra_5to_ciclo
{
    class Pistola:Armas
    {
        public string Nombre;
        public int Daño;
        public float AtSpd;
        public float Precio;
        public int BalaDaño;

        public Pistola(string nombre, int daño, float atSpd, float price,int DañoBala)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.AtSpd = atSpd;
            this.Precio = price;
            this.BalaDaño = DañoBala;
        }
        public override void Stats()
        {
            Console.WriteLine("Nombre" + Nombre);
            Console.WriteLine("Daño" + Daño);
            Console.WriteLine("AtSpd" + AtSpd);
            Console.WriteLine("Precio" + Precio);

            int a = Convert.ToInt32(Daño / AtSpd);
            Console.WriteLine("DPS" + a);
            Console.WriteLine("Se necesitan Balas");
        }
    }
}
