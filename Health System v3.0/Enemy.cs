using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Enemy:CHARACTER
    {
        private static int _enemyNum = 1;
        public Enemy(string name = "Enemy") 
        {
            string enemyNum = _enemyNum.ToString(); // overloads variable with string
            _enemyNum += 1;
            if (name != "Enemy") { _name = name; }
            else
            {
                _name = name + "#" + enemyNum;
            }
            _health = 100;
            Console.WriteLine("         " + _name + " appeared");
        } // << constructor
        public void ShowHUD()
        {
            int enemyBorder = 20 + _name.Length + _health.ToString().Length;
            Console.WriteLine();
            Console.Write("      ┌");
            for (int i = 0; i < enemyBorder; i++) { Console.Write("─"); }
            Console.WriteLine("┐");
            Console.WriteLine("      │ "+_name+ " Status │ Health: "+_health+ " │");
            Console.Write("      └");
            for (int i = 0; i < enemyBorder; i++) { Console.Write("─"); }
            Console.WriteLine("┘");
            Console.WriteLine();
        }// <<< displays Status of Enemy
        public void CallEnemy() 
        {
            Enemy enemy = new Enemy();
        
        }// <<< creates enemy for battle
    }
}
