using System;

namespace super_hero
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutant perso = new Mutant("coco");
            Humain lucas = new Humain("lucas");
            Console.WriteLine(perso.name + "  " + perso.lifePoint);
            Console.WriteLine(lucas.name + "   " + lucas.lifePoint);

            lucas.Muscle();
            lucas.TakeDamage(20);
            Console.ReadLine();
        }
    }
}
