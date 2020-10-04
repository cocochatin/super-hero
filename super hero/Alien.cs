using System;
using System.Collections.Generic;
using System.Text;

namespace super_hero
{
    class Alien : ISuperForce, IFly, IVisionx, IDamageable
    {
        public int lifePoint { get; set; }
        public string name { get; set; }
        public Alien(string name)
        {
            this.name = name;
            this.lifePoint = 400;
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
        public void Seetrought()
        {
            Console.WriteLine($"{name} can see anything");
        }
    }
}
