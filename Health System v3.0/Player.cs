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
        private bool _gameover = false;
        private int _shield;
        private string _lifeStatus;
        private int _lives;

        //methods:
        public Player(string name) {
            _name = name;
            _health = 100;
            _shield = 100;
            _lives = 3;

        } // constructor
        new public void TakeDamage(int damage) 
        {
            ErrorCheck(damage);
            Console.WriteLine("         "+this._name+" taking "+damage +" points of damage");
            int damageBleed = 0 ;
            _shield -= damage;
            damageBleed = -_shield;
            if (_shield <= 0 && damage != 0) { _health -= damageBleed; damageBleed = 0; }
            if (_shield <= 0 && damage == 0) { _health -= damage; } //calls ParentClass method
            if (_health <= 0) { _lives -= 1; }

        }// <<< deals damage to players shield then to health then to lives
        public void RegenShield(int regened)
        {
            ErrorCheck(regened);
            Console.WriteLine("         " + this._name+" Regenerated "+regened+" points of Shield");
            _shield += regened;

        }// <<< regenerates shield
        public void LifeRevive(int Rev)
        {
            ErrorCheck(Rev);
            Console.WriteLine("         " + this._name + " gained " + Rev + " lives");
                _lives += Rev;
            
        }// <<< Generates Lives to the players life count
        public void ShowHUD() 
        {
            CheckRange();
            CheckStatus();
            GameOver();
            int borderLength = 0;
            borderLength += _name.Length + 9 + _lifeStatus.Length + 10 + _health.ToString().Length + 10 + _shield.ToString().Length + 1 + 9 + _lives.ToString().Length + 3;
            Console.WriteLine();
            Console.Write("      █");
            for (int i = 0; i <= borderLength; i++)
            {
            Console.Write("▄");
            }
            Console.WriteLine("█");
            Console.Write("      █ " + _name + " Status: " + _lifeStatus + " ");
            Console.Write("█ Shield: " + _shield + " ");
            Console.Write("█ Health: " + _health + " ");
            Console.Write("█ Lives: " + _lives + " █ ");
            Console.WriteLine("");
            Console.Write("      █");
            for (int i = 0; i <= borderLength; i++)
            {
                Console.Write("▀");
            }
            Console.WriteLine("█");
            Console.WriteLine();
            if (_lives <= 0)
            {
                Console.WriteLine("         GAME OVER");
            }
        } // <<< Displays the Status of the Player
        public void GameOver() 
        {
            if (_lives > 0 && _health <= 0)
            {
                _health = 100;
            } // <<<< uses life instead of game over true, life calculated as damage in TakeDamage()
            if (_lives <= 0) 
            {   
                _lifeStatus = "X DEAD X";
                _gameover = true;
                
            } // <<<< writes game over message and ends game loop, gameover = true  ----- add option to continue?

        }// <<<< ShowHUD Child, updates death
        public void CheckStatus() 
        {
            if (_health >= 75) { _lifeStatus = "Healthy"; }
            else if (_health >= 50) { _lifeStatus = "Hurt"; }
            else if (_health >= 25) { _lifeStatus = "Danger"; }
            else if (_health <= 24) { _lifeStatus = "! Peril !"; }
        }// <<<< ShowHUD Child, updates state
        new public void CheckRange()
        {
            base.CheckRange(); 
            if (_shield >= 101) { _shield = 100; }
            else if (_shield <= 0) { _shield = 0; }
            if (_lives >= 100) { _lives = 99; }
            else if (_lives <= 0) { _lives = 0; }
        }// <<<< ShowHUD Child, fixes stats if they exeed the range


        //debug
        public void debugReset()
        {
            Console.WriteLine("         resetting " + this._name+" status values ");
            _health = 100;
            _shield = 100;
            _lives = 3;
        }// <<<< debugShowcase child
        public void debugSetShield(int value)
        {
            _shield = value;
            Console.WriteLine("         Setting " + this._name+" Shield to "+value);
        } // Sets the shield DEBUGONLY
    }
}
