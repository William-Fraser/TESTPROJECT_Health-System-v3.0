using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Enemy:CHARACTER
    {
        private static int _enemyNum;
        public Enemy() 
        {
            string enemyNum = _enemyNum.ToString(); // overloads variable with string
            _enemyNum += 1;
            _name = "Enemy" + enemyNum;
            
            _health = 100;
            Console.WriteLine("         Enemy " + _name + " appeared");
        } // << constructor
        public void CallEnemy() 
        {
            Enemy enemy = new Enemy();
        
        }// <<< creates enemy for battle
    }
}
