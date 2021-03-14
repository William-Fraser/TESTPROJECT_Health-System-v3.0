using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class testUnit
    {
        static Player playertest = new Player("bon jovi");
        

        //debugging
        public void PlayShowcase()
        {
            while (true)
            {
                
                ConsoleKeyInfo yn;
                
                Console.Write("Showcase debug? Y/N : ");
                yn = Console.ReadKey();
                if (yn.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    debugShowcase(playertest);
                }
                else if (yn.Key == ConsoleKey.N) { Console.Clear(); break; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Input operation");
                    Console.WriteLine();
                }
            }
        }//so you like to debug?
        private void debugShowcase(Player input)
        {
            ConsoleKeyInfo debugCode;
            ConsoleKeyInfo debugCodeTwo;


            while (true) 
            { 
                Console.WriteLine();
                Console.WriteLine("   debug Menu for "+input+"\n\n 0 - PlayAll\n 1 - Modification\n 2 - Range\n 3 - Error\n 4 - Enemy");
                Console.Write("Enter Value : ");
                debugCode = Console.ReadKey();
                input.debugReset();
                Console.Clear();
                if (debugCode.Key == ConsoleKey.D1 || debugCode.Key == ConsoleKey.D0) //modification debug
                {
                    debugCodeTwo = debugCode;
                    if (debugCode.Key != ConsoleKey.D0)
                    {
                        Console.WriteLine("\n   Modification debug Menu\n\n 4 - TakeDamage\n 5 - Heal \n 6 - RegenShield\n 7 - HealthStatus\n 8 - LifeRevive\n");
                        Console.Write("Enter Value : ");
                        debugCodeTwo = Console.ReadKey();
                        Console.Clear();
                    }
                    else { Console.WriteLine("\n         Modification debug"); }
                    if (debugCodeTwo.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for modification TakeDamage");
                        debugBorder();
                        input.ShowHUD();
                        input.TakeDamage(20);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                        Console.WriteLine("         taking damage and Shield 'bleeds' into Health");
                        debugBorder();
                        input.debugSetShield(30);
                        input.ShowHUD();
                        input.TakeDamage(107);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                        Console.WriteLine("         taking damage and losing a Life");
                        debugBorder();
                        input.ShowHUD();
                        input.TakeDamage(999);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D5 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for modification Heal");
                        debugBorder();
                        input.debugSetHealth(50);
                        input.ShowHUD();
                        input.Heal(25);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();

                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D6 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for modification RegenShield");
                        debugBorder();
                        input.debugSetShield(33);
                        input.ShowHUD();
                        input.RegenShield(17);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();

                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D7 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for modification HealthStatus");
                        debugBorder();
                        input.debugSetShield(0);
                        input.debugSetHealth(76);
                        input.ShowHUD();
                        input.TakeDamage(3);
                        input.ShowHUD();
                        input.TakeDamage(25);
                        input.ShowHUD();
                        input.TakeDamage(25);
                        input.ShowHUD();
                        input.TakeDamage(25);
                        input.ShowHUD();
                        input.TakeDamage(999);
                        input.ShowHUD();
                        input.TakeDamage(999);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D8 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for modification LifeRevive");
                        debugBorder();
                        input.debugSetShield(25);
                        input.debugSetHealth(50);
                        input.ShowHUD();
                        input.LifeRevive(1);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();

                    }
                    else {  }
                }///////1 modify
                else if (debugCode.Key == ConsoleKey.D2 || debugCode.Key == ConsoleKey.D0) //Range debug
                {
                    debugCodeTwo = debugCode;
                    if (debugCode.Key != ConsoleKey.D0)
                    {
                        Console.WriteLine("\n   Range debug Menu\n\n 4 - health\n 5 - shield\n 6 - lives\n");
                        Console.Write("Enter Value : ");
                        debugCodeTwo = Console.ReadKey();
                        Console.Clear();
                    }
                    else { Console.WriteLine("\n         Range debug"); }
                    if (debugCodeTwo.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for range checking health");
                        debugBorder();
                        input.debugSetShield(0);
                        input.debugSetHealth(70);
                        input.ShowHUD();
                        input.Heal(100);
                        input.ShowHUD();
                        input.TakeDamage(100);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D5 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for range checking shield");
                        debugBorder();
                        input.debugSetShield(80);
                        input.ShowHUD();
                        input.RegenShield(101);
                        input.ShowHUD();
                        input.TakeDamage(101);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D6 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for range checking lives");
                        debugBorder();
                        input.ShowHUD();
                        input.TakeDamage(200);
                        input.ShowHUD();
                        input.TakeDamage(100);
                        input.ShowHUD();
                        input.TakeDamage(100);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else { }
                }//2 range
                if (debugCode.Key == ConsoleKey.D3 || debugCode.Key == ConsoleKey.D0) //ERR debug
                {
                    debugCodeTwo = debugCode;
                    if (debugCode.Key != ConsoleKey.D0)
                    {
                        Console.WriteLine("\n   Error debug Menu\n\n 4 - takeDamage\n 5 - Heal\n 6 - RegenShield\n FIX*7 - lifeRevive\n");
                        Console.Write("Enter Value : ");
                        debugCodeTwo = Console.ReadKey();
                        Console.Clear();
                    }
                    else { Console.WriteLine("\n         Error debug"); }
                    if (debugCodeTwo.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for error checking takeDamage");
                        debugBorder();
                        input.ShowHUD();
                        input.TakeDamage(-50);
                        input.ShowHUD();
                        input.TakeDamage(-75);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D5 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for error checking Heal");
                        debugBorder();
                        input.debugSetHealth(1);
                        input.ShowHUD();
                        input.Heal(-999);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D6 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for error checking RegenShield");
                        debugBorder();
                        input.debugSetShield(7);
                        input.ShowHUD();
                        input.RegenShield(-700);
                        input.ShowHUD();
                        input.debugReset();
                        debugBorder();
                    }
                    else if (debugCodeTwo.Key == ConsoleKey.D7 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for error checking lifeRevive");
                        debugBorder();
                        input.debugSetShield(20);
                        input.debugSetHealth(50);
                        input.ShowHUD();
                        input.LifeRevive(-500);
                        input.debugReset();
                        debugBorder();

                    }         
                    else { }
                }//3 error
                if (debugCode.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0) //modification debug
                {
                    debugCodeTwo = debugCode;
                    if (debugCode.Key != ConsoleKey.D0)
                    {
                        Console.WriteLine("\n   Enemy debug Menu\n\n 4 - Enemy.TakeDamage\n 5 - Enemy.Heal \n 6 - Enemy(name)");
                        Console.Write("Enter Value : ");
                        debugCodeTwo = Console.ReadKey();
                        Console.Clear();
                    }
                    else { Console.WriteLine("\n         Enemy debug"); }
                    if (debugCodeTwo.Key == ConsoleKey.D4 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for Enemy.TakeDamage");
                        debugBorder();
                        Enemy enemy1 = new Enemy();
                        enemy1.ShowHUD();
                        enemy1.TakeDamage(20);
                        enemy1.ShowHUD();
                        debugBorder();
                    }
                    if (debugCodeTwo.Key == ConsoleKey.D5 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for Enemy.Heal");
                        debugBorder();
                        Enemy enemy2 = new Enemy();
                        enemy2.debugSetHealth(25);
                        enemy2.ShowHUD();
                        enemy2.Heal(25);
                        enemy2.ShowHUD();
                        debugBorder();

                    }
                    if (debugCodeTwo.Key == ConsoleKey.D6 || debugCode.Key == ConsoleKey.D0)
                    {
                        debugBorder();
                        Console.WriteLine("         displaying debug for Enemy(name)");
                        debugBorder();
                        Enemy bigBoss = new Enemy("Big Boss");
                        bigBoss.ShowHUD();
                        debugBorder();

                    }
                    else { }
                }
                if (debugCode.Key == ConsoleKey.D0) { Console.WriteLine(" to exit debug press ESC"); }
                if (debugCode.Key == ConsoleKey.Escape)// escape
                {
                    if (debugCode.Key == ConsoleKey.D0) { Console.WriteLine("Played All"); }

                    debugBorder();
                    Console.WriteLine("Exiting the debug");
                    debugBorder();
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    break;
                }
                else { }
                Console.ReadKey(true);
                Console.Clear();
            }
        }//actual healthsystem debug
        private void debugBorder() 
        {
            Console.WriteLine();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("~");
            }
            Console.WriteLine("\n");
        }// easier way to say BORDER
    }
}
