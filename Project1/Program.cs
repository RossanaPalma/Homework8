using Microsoft.VisualBasic.CompilerServices;
using System;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int aaronWins, bobWins, charlieWins = 0;
            
            for(int i = 0; i < 10000; i++)
            {
                Duelist aaron = new Duelist("Aaron", 0.33);
                Duelist bob = new Duelist("Bob", 0.5);
                Duelist charlie = new Duelist("Charlie", 0.995);
                int count 3; // shooters alive

                while (count > 1)
                {
                    if (aaron.Alive)
                    {
                        if (charlie.Alive)
                        {
                            aaron.ShootAtTarget(charlie);
                            if (!charlie.Alive)
                            {
                                count--;
                            }
                        }
                        else
                        {
                            aaron.ShootAtTarget(bob)
                                if (!bob.Alive)
                            {
                                count--;
                            }
                        }
                    }
                    if (bob.Alive)
                    {
                        if (charlie.Alive)
                        {
                            bob.ShootAtTarget(charlie);
                            if (!charlie.Alive)
                            {
                                count--;
                            }
                        }
                        else
                        {
                            bob.ShootAtTarget(aaron);
                            if (aaron.Alive)
                            {
                                aaronWins++;
                            }
                        }
                    }
                    if (charlie.Alive)
                    {
                        if (bob.Alive)
                        {
                            charlie.ShootAtTarget(bob);
                            if (!bob.Alive)
                            {
                                count--;
                            }
                            else
                            {
                                charlie.ShootAtTarget(aaron);
                                if (!aaron.Alive)
                                {
                                    count--;
                                }
                            }
                        }
                    }
                    if (aaron.Alive)
                    {
                        aaronWins++;
                    }
                    else if (bob.Alive)
                    {
                        bobWins++;
                    }
                    else
                    {
                        charlieWins++;
                    }
                }
                Console.WriteLine("Aaron won {0} times.", aaronWins);
                Console.WriteLine("Bob won {0} times,", bobWins);
                Console.WriteLine("Charlie won {0} times.", charlieWins);
            }
            Console.ReadLine();
            }
        }
    }

