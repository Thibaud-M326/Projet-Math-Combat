using System;

namespace MathCode
{
    class Monster
    {
        public string monsterName;
        public int sword01;
        public int sword02;
        public int monsterPV;

        public Monster(string _monsterName)
        {
            monsterName = _monsterName;
            monsterPV = 1;
            sword01 = 0;
            sword02 = 0;
        }

        public void RollSwords()
        {
            Random numberGen = new Random();
            sword01 = numberGen.Next(1, 10);
            sword02 = numberGen.Next(1, 10);
        }
    }

    class Hero
    {
        public string heroName;
        public int heroPV;

        public Hero(string _heroName)
        {
            heroName = _heroName;
            heroPV = 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //creation variables
            int mAddition;
            int hResult;

            //creation hero et monster
            Monster monster01 = new Monster("Gobelin");
            Hero hero01 = new Hero("Jason");

            //apparition de monster
            Console.WriteLine("Un " + monster01.monsterName + " apparait, il veut vous combattre:");

            //lancer aleatoire du calcul mental, et la valeur calculée
            monster01.RollSwords();
            mAddition = monster01.sword01 + monster01.sword02;
            
            //debut du combat
            while(hero01.heroPV > 0 && monster01.monsterPV > 0)
            {
                Console.WriteLine("\n\n" + hero01.heroName + " PV = " + hero01.heroPV + "\n");
                Console.Write(monster01.sword01 + " + " + monster01.sword02 + " = ");
                hResult = Convert.ToInt32(Console.ReadLine());
                hero01.heroPV--;
            }
            
            //arrette le programme
            Console.ReadKey();
        }
    }
}