using System;
using System.Collections.Generic;
using System.Text;

namespace super_hero
{
    class Mutant : IFly, IVisionx, IDamageable
    {
        public int lifePoint { get; set; }
        public string name { get; set; }
        public Mutant(string nom)
        {
            this.name = nom;
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
        public void Seetrought()
        {
            Console.WriteLine($"{name} can see anything");
        }
    }
}
