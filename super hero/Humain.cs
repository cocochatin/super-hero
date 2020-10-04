using System;
using System.Collections.Generic;
using System.Text;

namespace super_hero
{
    class Humain : ISuperForce, IFly, IDamageable
    {
        public int lifePoint { get; set; }
        public string name { get; set; }
        public Humain(string name)
        {
            this.name = name;
            this.lifePoint = 100;
        }
        public void TakeDamage(int point)
        {
            lifePoint -= point;
            Console.WriteLine($"{name} as taken dammage and has still {lifePoint} life point");
        }
        public void Fly()
        {
            Console.WriteLine($"{name} believe he can fly ");
        }
        public void Muscle()
        {
            Console.WriteLine($"{name} is stronger than anyone");
        }
    }
}
