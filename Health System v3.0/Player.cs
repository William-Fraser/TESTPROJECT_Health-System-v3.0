using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player : CHARACTER
    {
        //fields:
        public string _name;
        public int _shield;
        private string _lifeStatus;
        private int _lives;

        //methods:
        public Player(string name) {
            _name = name;
            _health = 100;
            _shield = 100;
            _lives = 3;

        }
        public Player()
        {

        } // for Management Inheritance
        new public void TakeDamage(int damage) 
        {
            int damageBleed = 0 ;
            _shield -= damage;
            damageBleed = _shield;
            if (_shield <= 0 && damage != 0) { _health -= damageBleed; damageBleed = 0; }
            if (_shield <= 0 && damage == 0) { _health -= damage; } //calls ParentClass method
            if (_health <= 0) { _lives -= 1; }

        }
        public void RegenShield(int regened)
        {
            _shield += regened;

        }
        public void ShowHUD() 
        {
            CheckStatus();
            int borderLength = 0;
            borderLength += _name.Length + 9 + _lifeStatus.Length +1+ 10 + _health.ToString().Length +1+ 10 + _shield.ToString().Length+1+ 9 + _lives.ToString().Length+ 3;
            Console.WriteLine();
            Console.Write("      ");
            for (int i = 0; i <= borderLength; i++)
            {
                Console.Write("▄");
            }   
            Console.WriteLine();
            Console.Write("      █ " + _name + " Status: "+_lifeStatus+" ");
            Console.Write("█ Health: " + _health+" ");
            Console.Write("█ Shield: " + _shield+" ");
            Console.Write("█ Lives: " + _lives + " █ ");
            Console.WriteLine("");
            Console.Write("      ");
            for (int i = 0; i <= borderLength; i++)
            {
                Console.Write("▀");
            }

        }
        public void CheckStatus() 
        {
            if (_health >= 75) { _lifeStatus = "Healthy"; }
            else if (_health >= 50) { _lifeStatus = "Hurt"; }
            else if (_health >= 25) { _lifeStatus = "Danger"; }
            else if (_health <= 24) { _lifeStatus = "! Peril !"; }

        }
        public void GameOver() 
        {
            if (_lives <= 0) 
            {
               // ShowHUD();

            }

        }
        new public void CheckRange() 
        {
            CheckRange();
            if (_shield >= 100) { _shield = 100; }
            else if (_shield <= 0) { _shield = 0; }

            if (_lives >= 99) { _lives = 99; }
            else if (_lives <= 0) { _lives = 0; }

        }
        public void debugReset()
        {
            _health = 100;
            _shield = 100;
            _lives = 3;
        }//debugShowcase child
    }
}
