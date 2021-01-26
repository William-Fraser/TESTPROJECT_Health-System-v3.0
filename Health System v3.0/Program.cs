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
///develop a health system
///implement in a Player class
///implement in an Enemy class
///use inheritance(and all that that implies)
///Showcase all the functionality, including range checking and error checking.
/// 
/// 
/// GOALS TO HIT proper coding conventions and object-oriented programming architecture (and all that that implies):
///
///encapsulation
///constructor
///inheritance
///abstract classes
///base(parent) classes
///derived(child) classes
///proper naming conventions
///access modifiers (private/public/static)
///fields / methods
///namespaces
///range checking
///error checking
///
/// ...details of all the above omitted on purpose.
/// </TODO>
namespace Health_System_v3._0
{
    class Program
    {
        static Player player1 = new Player("bon jovi");
        static Battle_Manager_SYSTM BMS = new Battle_Manager_SYSTM();
        ///CHARACTER Parent of Player, Enemy:
        ///     TakeDamage, Heal, CheckRange(call before display)
        /// Player: Player(string), TakeDamage(int), RegenShield(int), ShowHUD, CheckStatus, GameOver, CheckRange  
        /// Enemy: Enemy, CallEnemy
        static void Main(string[] args)
        {
            BMS.playShowcase(player1);

            Console.ReadKey(true);
        }
        
    }
}
