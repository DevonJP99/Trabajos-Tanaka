using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace trabajos_Progra_5to_ciclo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            bool continuidad = true;
            List<Armas> inv = new List<Armas>();

            while (continuidad)
            {
                string seleccionar;
                Console.WriteLine("1: Comprar arma");
                Console.WriteLine("2: Inventario");
                Console.WriteLine("3: Salida");

                seleccionar = Console.ReadLine();
                Console.Clear();

                switch (seleccionar)
                {
                    case "1":

                        Console.WriteLine("Seleccion de compra");
                        Console.WriteLine("Armas");
                        Console.WriteLine("1) Pistola");
                        Console.WriteLine("2) Arco");
                        Console.WriteLine("3) Espada");
                        Console.WriteLine("Municiones");
                        Console.WriteLine("4) Balas");
                        Console.WriteLine("5) Flechas");

                        seleccionar = Console.ReadLine();
                        Console.Clear();

                        Bala bala = new Bala("balita", 12, 33);
                        Flecha flech = new Flecha("flecha", 23, 12);

                        switch (seleccionar)
                        {
                            case "1":
                                Pistola pistol = new Pistola("Pistola", 20, 2f, 11, bala.Daño);
                                pistol.Stats();
                                inv.Add(pistol);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "2":

                                Arco arc = new Arco("Arco", 122, 2.5f, 123, flech.Daño);
                                arc.Stats();
                                inv.Add(arc);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "3":

                                Espada spada = new Espada("Espada", 500, 2f, 50);
                                spada.Stats();
                                inv.Add(spada);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "4":

                                bala.Stats();
                                inv.Add(bala);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case "5":

                                flech.Stats();
                                inv.Add(flech);
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Ta vacio");
                                Console.ReadLine();
                                Console.Clear();

                                break;

                        }

                        break;

                    case "2": //inventario 

                        if (inv.Count > 0)
                        {
                            for (int i = 0; i < inv.Count; i++)
                            {
                                Console.WriteLine(inv[i].GetType().Name);
                            }


                            Console.WriteLine("1) Botar del inventario ");
                            Console.WriteLine("2) Regresar ");
                            seleccionar = Console.ReadLine();
                            Console.Clear();

                            switch (seleccionar)
                            {
                                case "1":

                                    for (int i = 0; i < inv.Count; i++)
                                    {

                                        Console.WriteLine(i + "" + inv[i].GetType().Name);
                                    }

                                    int a = int.Parse(Console.ReadLine()); //convierte de texto a entero

                                    inv.Remove(inv[a]);

                                    Console.Clear();

                                    break;

                                case "2":



                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ta vacio");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;

                    case "3":
                        continuidad = false;
                        break;
                }
            }
        }
    }
}
