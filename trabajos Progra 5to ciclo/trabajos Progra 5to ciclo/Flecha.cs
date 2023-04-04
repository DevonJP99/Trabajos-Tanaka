using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajos_Progra_5to_ciclo
{
    class Flecha:Armas

    {
        public string Nombre;
        public int Daño;
        public float Precio;

        public Flecha(string nombre, int daño, float precio)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.Precio = precio;
        }
        public override void Stats()
        {
            Console.WriteLine("Nombre " + Nombre);
            Console.WriteLine("Daño " + Daño);
            Console.WriteLine("Precio " + Precio);
        }
    }
}
