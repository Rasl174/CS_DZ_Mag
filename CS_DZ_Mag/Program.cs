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
            int heroHealth = 2700;
            int demonHealth = 2000;
            int heroDamage = 100;
            int demonDamage = 150;
            int graceDamage = 500;
            int sunlightDamage = 200;
            int metheorDamage = 250;
            int mana = 100;
            int manaEveryTurn = 10;
            int variantsHeroDamage = 4;
            int manaGrace = 50;
            int manaSunlight = 20;
            int manaMetheor = 30;
            bool spellSunlightDone = false;

            Console.WriteLine("Да начнется битва: ");

            while (heroHealth > 0 && demonHealth > 0)
            {
                if (mana <= 90)
                {
                    mana += manaEveryTurn;
                }
                heroHealth -= demonDamage;
                Console.WriteLine("Герой получил урон. осталось : " + heroHealth + " жизней");

                switch (variantsHeroDamage = rand.Next(0, 5))
                {
                    
                    case 1:
                        mana += manaEveryTurn;
                        demonHealth -= heroDamage;
                        Console.WriteLine("Демон получил урон. осталось : " + demonHealth + " жизней");
                        break;

                    case 2:
                        if (mana >= manaGrace && spellSunlightDone == true)
                        {
                            spellSunlightDone = false;
                            demonHealth -= graceDamage;
                            mana -= manaGrace;
                            Console.WriteLine("Герой применил заклинание Благодать. У демона осталось : " + demonHealth + " жизней");
                        }
                        else if (spellSunlightDone == false) 
                        {
                            Console.WriteLine("Требуется выполнить заклинание Солнечный свет!");
                        }

                        else if (mana <= manaGrace) 
                        {
                            Console.WriteLine("Недостаточно маны! ");
                        }
                        
                        break;

                    case 3:
                        if (mana >= manaSunlight)
                        {
                            spellSunlightDone = true;
                            demonHealth -= sunlightDamage;
                            mana -= manaSunlight;
                            Console.WriteLine("Герой применил заклинание Солнечный свет. У демона осталось : " + demonHealth + " жизней");
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно маны! ");
                        }
                        break;

                    case 4:
                        if (mana >= manaMetheor)
                        {
                            demonHealth -= metheorDamage;
                            mana -= manaMetheor;
                            Console.WriteLine("Герой применил заклинание Метеорит. У демона осталось : " + demonHealth + " жизней");
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно маны! ");
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
