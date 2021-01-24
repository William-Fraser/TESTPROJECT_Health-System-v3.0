using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <sharedmembers>
/// members:
///fields:
///shield(0..100)
///health(0..100)
///lives(0..)
///methods:
///TakeDamage()-- reduces health
///Heal() --increases health
///RegenerateShield() --increases shield
///ShowHUD() --show game character's stats (for debugging purposes)

/// </shared members>

namespace Health_System_v3._0
{
    class CHARACTER
    {
        //fields:
        public int _health;

        //methods:
        public void TakeDamage(int damage) 
        {
            _health -= damage;
        
        }
        public void Heal(int healing) 
        {
            _health += healing;

        }
        public void CheckRange() 
        {
            if (_health >= 101) { _health = 100; }
            if (_health <= 0) { _health = 100; }

        }

    }
}
