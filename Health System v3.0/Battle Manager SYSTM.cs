using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Battle_Manager_SYSTM:Player
    {
        
        //debugging
        public void playShowcase(Player player)
        {
            while (true)
            {
                
                ConsoleKeyInfo yn;
                
                Console.Write("Showcase debug? Y/N : ");
                yn = Console.ReadKey();
                if (yn.Key == ConsoleKey.Y)
                {
                    debugShowcase(player);
                }
                else if (yn.Key == ConsoleKey.N) { break; }
                else
                {
                    Console.WriteLine("Input operation");
                }
            }
        }//let the show begin.

        private void debugShowcase(Player player)//fix this
        {
            ConsoleKeyInfo debugCode;
            ConsoleKeyInfo debugCodeTwo;

            player.debugReset();

            while (true) 
            { 
                Console.WriteLine();
                Console.WriteLine("  debug Menu \n\n 0 - PlayAll\n 1 - Modification\n 2 - Range\n 3 - Error\n");
                Console.Write("Enter Value : ");
                debugCode = Console.ReadKey();
                if (debugCode.Key == ConsoleKey.D1 || debugCode.Key == ConsoleKey.D0) //modification debug
                {
                    debugCodeTwo = debugCode;
                    if (debugCode.Key != ConsoleKey.D0)
                    {
                        Console.WriteLine("   Modification debug Menu\n\n 4 - TakeDamage\n 5 - Heal \n 6 - RegenShield\n 7 - healthStatus\n FIX* 8 - LifeRevive");
                        Console.Write("Enter Value : ");
                        debugCodeTwo = Console.ReadKey();
                    }
                    else 
                    { }
                    if (debugCodeTwo.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for modification TakeDamage");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player.ShowHUD();
                        player.TakeDamage(20);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("taking damage and _shield 'bleeds' into health");
                        player._shield = 90;
                        player.ShowHUD();
                        player.TakeDamage(107);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("taking damage and losing a 'live'");
                        player.ShowHUD();
                        player.TakeDamage(999);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D5 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for modification Heal");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._health = 50;
                        player.ShowHUD();
                        player.Heal(25);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();

                    }
                    if (debugCodeTwo.Key == ConsoleKey.D6 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for modification RegenShield");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 33;
                        player.ShowHUD();
                        player.RegenShield(17);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();

                    }
                    if (debugCodeTwo.Key == ConsoleKey.D7 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for modification healthStatus");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 0;
                        player._health = 76;
                        player.ShowHUD();
                        player.TakeDamage(3);
                        player.ShowHUD();
                        player.TakeDamage(25);
                        player.ShowHUD();
                        player.TakeDamage(25);
                        player.ShowHUD();
                        player.TakeDamage(25);
                        player.ShowHUD();
                        player.TakeDamage(999);
                        player.ShowHUD();
                        player.TakeDamage(999);
                        player.ShowHUD();
                        player.TakeDamage(999);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D8 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for modification lifeRevive");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 25;
                        player._health = 50;
                        player.ShowHUD();
                        //player.lifeRevive(1);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();

                    }
                    else {  }
                }///////1 modify
                if (debugCode.Key == ConsoleKey.D2 || debugCode.Key == ConsoleKey.D0) //Range debug
                {
                    debugCodeTwo = debugCode;
                    if (debugCode.Key != ConsoleKey.D0)
                    {
                        Console.WriteLine("   Range debug Menu\n\n 4 - health\n 5 - ,6,7");
                        Console.Write("Enter Value : ");
                        debugCodeTwo = Console.ReadKey();
                    }
                    else { }
                    if (debugCodeTwo.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for range checking health");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 0;
                        player._health = 75;
                        player.ShowHUD();
                        player.Heal(100);
                        player.ShowHUD();
                        player.TakeDamage(100);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D5 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for range checking shield");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 80;
                        player.ShowHUD();
                        player.RegenShield(100);
                        player.ShowHUD();
                        player.TakeDamage(100);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D6 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for range checking lives");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player.ShowHUD();
                        player.TakeDamage(200);
                        player.ShowHUD();
                        player.TakeDamage(100);
                        player.ShowHUD();
                        player.TakeDamage(100);
                        player.ShowHUD();
                        player.TakeDamage(100);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D7 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for range checking lifeRevive");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 25;
                        player._health = 50;
                        player.ShowHUD();
                        //player.lifeRevive(10000);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();

                    }
                    else { }
                }//2 range
                if (debugCode.Key == ConsoleKey.D3 || debugCode.Key == ConsoleKey.D0) //ERR debug
                {
                    debugCodeTwo = debugCode;
                    if (debugCode.Key != ConsoleKey.D0)
                    {
                        Console.WriteLine("4,5,6,7. Error debug Menu");
                        Console.Write("Enter Value : ");
                        debugCodeTwo = Console.ReadKey();
                    }
                    else { }
                    if (debugCodeTwo.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for error checking takeDamage");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player.ShowHUD();
                        player.TakeDamage(-50);
                        player.ShowHUD();
                        player.TakeDamage(-75);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D5 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for error checking Heal");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._health = 1;
                        player.ShowHUD();
                        player.Heal(-999);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D6 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for error checking RegenShield");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 7;
                        player.ShowHUD();
                        player.RegenShield(-700);
                        player.ShowHUD();
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D7 || debugCode.Key == ConsoleKey.D0)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        Console.WriteLine("displaying debug for error checking lifeRevive");
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();
                        player._shield = 25;
                        player._health = 50;
                        player.ShowHUD();
                        //player.lifeRevive(-500);
                        player.debugReset();
                        Console.WriteLine();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine();

                    }
                    else { }
                }//3 error
                if (debugCode.Key == ConsoleKey.Escape || debugCode.Key == ConsoleKey.D0)// escape
                {
                    if (debugCode.Key == ConsoleKey.D0) { Console.WriteLine("Played All"); }

                    Console.WriteLine("Exiting the debug");

                    break;
                }
                else { }
            }
        }

    }
}
