using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Mag
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int heroHealth = 2000;
            int demonHealth = 2500;
            int heroDamage = 100;
            int demonDamage = 300;
            int grace = 250;
            int sunlight = 100;
            int metheor = 150;
            int mana = 100;
            int manaEveryTurn = 10;
            int spellNumber;
            int manaGrace = 50;
            int manaSunlight = 20;
            int manaMetheor = 35;

            Console.WriteLine("Да начнется битва: ");

            while (heroHealth > 0 && demonHealth > 0)
            {
                 switch (spellNumber = rand.Next(0, 5))
                {
                    case 1:
                        mana += manaEveryTurn;
                        heroHealth -= demonDamage;
                        Console.WriteLine("Герой получил урон. осталось : " + heroHealth + " жизней");
                        break;

                    case 2:
                        mana += manaEveryTurn;
                        demonHealth -= heroDamage;
                        Console.WriteLine("Демон получил урон. осталось : " + demonHealth + " жизней");
                        break;

                    case 3:
                        if (mana >= manaGrace)
                        {
                            demonHealth -= grace;
                            mana -= manaGrace;
                            Console.WriteLine("Герой применил заклинание Благодать. У демона осталось : " + demonHealth + " жизней");
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно маны! ");
                            mana += manaEveryTurn;
                        }
                        break;

                    case 4:
                        if (mana >= manaSunlight)
                        {
                            demonHealth -= sunlight;
                            mana -= manaSunlight;
                            Console.WriteLine("Герой применил заклинание Солнечный свет. У демона осталось : " + demonHealth + " жизней");
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно маны! ");
                            mana += manaEveryTurn;
                        }
                        break;

                    case 5:
                        if (mana >= manaMetheor)
                        {
                            demonHealth -= metheor;
                            mana -= manaMetheor;
                            Console.WriteLine("Герой применил заклинание Метеорит. У демона осталось : " + demonHealth + " жизней");
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно маны! ");
                            mana += manaEveryTurn;
                        }
                        break;

                }
            }

            if (heroHealth <= 0 && demonHealth <= 0)
            {
                Console.WriteLine("Оба погибли. ");
            }
            else if (heroHealth <= 0)
            {
                Console.WriteLine("Наш герой пал смертью храбрых. ");
            }
            else if (demonHealth <= 0)
            {
                Console.WriteLine("Мы победили демона");
            }
        }
    }
}
