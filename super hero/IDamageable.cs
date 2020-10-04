using System;
using System.Collections.Generic;
using System.Text;

namespace super_hero
{
    interface IDamageable
    {
        int lifePoint { get; set; }
        void TakeDamage(int _amount);
    }
}
