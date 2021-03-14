using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <TODO>
/// 
/// Hide Folder Information
///Instructions
///Project - Health System v3.0:
///
///Create an OOP health system:
///
///develop a health system-------------------------------
///implement in a Player class-------------------------------
///implement in an Enemy class-------------------------------------
///use inheritance(and all that that implies)-----------------------------------------------
///Showcase all the functionality, including range checking and error checking.
/// 
/// 
/// GOALS TO HIT proper coding conventions and object-oriented programming architecture (and all that that implies):
///
///encapsulation - creating a class
///constructor - the class constructor
///inheritance - from a parent class
///abstract classes - can't be instaniated
///base(parent) classes - YES
///derived(child) classes - ABSOLUTELY
///proper naming conventions - idk
///access modifiers (private/public/static) - ye
///fields / methods - yeye
///namespaces -yeyeye
///range checking - i think
///error checking - i hope
///
/// EXTRA MILE
/// Naming player
/// Combat
/// level system
/// scaling max health with levels
/// 
/// ...details of all the above omitted on purpose.
/// </TODO>
namespace Health_System_v3._0
{
    class Program
    {
        static Player player1 = new Player("bon jovi");
        static testUnit unitTest = new testUnit();
        ///CHARACTER Parent of Player, Enemy:
        ///     TakeDamage, Heal, CheckRange(call before display)
        /// Player: Player(string), TakeDamage(int), RegenShield(int), ShowHUD, CheckStatus, GameOver, CheckRange  
        /// Enemy: Enemy, CallEnemy
        static void Main(string[] args)
        {
            unitTest.PlayShowcase();

            Console.ReadKey(true);
        }
        
    }
}
