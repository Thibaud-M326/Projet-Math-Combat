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
            heroPV = 1;
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
            Console.WriteLine("Un " + monster01.monsterName + " apparait, il veut vous combattre:\n");

            //lancer aleatoire du calcul mental, son affichage et la valeur calculée
            monster01.RollSwords();
            Console.Write(monster01.sword01 + " + " + monster01.sword02 + " = ");
            mAddition = monster01.sword01 + monster01.sword02;

            //prise du resultat du joueur
            hResult = Convert.ToInt32(Console.ReadLine());
            
            //---verification que les valeurs de resultats sont les bonnes
            //Console.WriteLine(mAddition);
            //Console.WriteLine(hResult);
            
            //debut du combat
            while(hero01.heroPV > 0 && monster01.monsterPV > 0)
            {
                if (hResult == mAddition)
                {
                    monster01.monsterPV --;
                    Console.WriteLine("\nFelicitation " + hero01.heroName + " à battu le demoniaque " + monster01.monsterName);
                }
                else if (hResult != mAddition)
                {
                    hero01.heroPV --;
                    Console.WriteLine("\nIl reste " + hero01.heroPV + " PV à " + hero01.heroName + "\n");
                }
            }

            if (hero01.heroPV == 0)
            {
                Console.WriteLine("Les forces du mal on été plus forte que " + hero01.heroName + " ,là maintenant il repose loin d'ici (on espere que ça vas).");
            }
            
            //arrette le programme
            Console.ReadKey();
        }
    }
}