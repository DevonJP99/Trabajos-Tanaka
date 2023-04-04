using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajos_Progra_5to_ciclo
{
    class Arco:Armas
    {
        public string Nombre;
        public int Daño;
        public float AtSpd;
        public float Precio;
        public int FlechaDaño;

        public Arco(string nombre, int daño, float atSpd, float price,int DañoFlecha)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.AtSpd = atSpd;
            this.Precio = price;
            this.FlechaDaño = DañoFlecha;
        }
        public override void Stats()
        {
            Console.WriteLine("Nombre " + Nombre);
            Console.WriteLine("Daño" + Daño);
            Console.WriteLine("Velocidad de ataque" + AtSpd);
            Console.WriteLine("Precio" + Precio);
            int a = Convert.ToInt32(Daño / AtSpd);

            Console.WriteLine("DPS" + a);
            Console.WriteLine("Se necesitan flechas");

        }
    }
}
