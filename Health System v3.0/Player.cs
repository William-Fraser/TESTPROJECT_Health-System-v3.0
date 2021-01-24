using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player:CHARACTER
    {
        //fields:
        private string _name;
        private string _lifeStatus;
        private int _shield;
        private int _lives;

        //methods:
        public Player(string name) {
            _name = name;
            _health = 100;
            _shield = 100;
            _lives = 3;

        }
        new public void TakeDamage(int damage) 
        {
            _shield -= damage;
            if (_shield <= 0) { TakeDamage(damage); } //calls ParentClass method
            if (_health <= 0) { _lives -= 1; }

        }
        public void RegenShield(int regened)
        {
            _shield += regened;

        }
        public void ShowHUD() 
        {
            int border = 2 + _name.Length + 9 + _lifeStatus.Length + 3 + 10 + _health.ToString().Length + 3 + 10 + _shield.ToString().Length + 3 + 9 + _lives.ToString().Length + 3;
            CheckStatus();
            Console.WriteLine();
            for (int i = 0; i <= border; i++)
            {
                Console.WriteLine("▄");
            }
            Console.Write("█ " + _name + " Status: "+_lifeStatus+" █ ");
            Console.Write("█ Health: " + _health + " █ ");
            Console.Write("█ Shield: " + _shield + " █ ");
            Console.Write("█ Lives: " + _lives + " █ ");
            Console.WriteLine("");
            for (int i = 0; i <= border; i++)
            {
                Console.WriteLine("▄");
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
    }
}
