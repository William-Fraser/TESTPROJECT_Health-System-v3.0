using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Enemy:CHARACTER
    {
        public static int _enemyNum;
        public static string _enemyName;
        public Enemy() 
        {
            _health = 100;
            string enemyNum = _enemyNum.ToString();
            _enemyNum += 1;
            _enemyName = "Enemy" + enemyNum;
        }
        public void CallEnemy() 
        {
            Enemy enemy = new Enemy();
        
        }
    }
}
