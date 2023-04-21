using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra
{
    internal class Enemy : IshowData
    {
        string name;
        int level;

        public virtual string GetName(string name)
        {
            this.name = name;
            return name;
        }

        public virtual int GetLevel(int level)
        {
            this.level = level;
            return level;
        }

        public string ShowDataEnemy()
        {
            return "Nombre: " + name + "Nivel: " + level;
        }

        public void AddEnemy()
        {
            Console.WriteLine("Enemigo");
            Enemy enemy = new Enemy();
            Console.WriteLine("Enemy name: ");
            string enemyName = Console.ReadLine();
            enemy.GetName(enemyName);

            Console.WriteLine("digite su experiencia:");
            int enemyLevel = int.Parse(Console.ReadLine());
            enemy.GetLevel(enemyLevel);
            Console.WriteLine(enemy.ShowDataEnemy());
        }

        public string ShowData()
        {
            return name;
        }
    }

}