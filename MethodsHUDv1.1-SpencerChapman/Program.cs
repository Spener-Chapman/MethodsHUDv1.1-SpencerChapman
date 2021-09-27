using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHUDv1._1_SpencerChapman
{
    class Program
    {
        static int Health;
        static int Maxhealth;
        static int Mana;
        static int Maxmana;
        static int Level;
        static int Xp;
        static float ScoreMultiplier;
        static int Score;
        static string Name;

        

        static void ShowHud()
        {
            Console.WriteLine("=========================");
            Console.WriteLine(" " + Name + "  Score:" + Score);
            Console.WriteLine(" HP:" + Health + "/" + Maxhealth + " " + "MP:" + Mana + "/" + Maxmana);
            Console.WriteLine(" Lvl:" + Level + " " + "Xp:" + Xp + " Soul Power:" + ScoreMultiplier);
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Name = "Musu";
            Score = 0;
            Maxhealth = 100;
            Health = Maxhealth;
            Maxmana = 100;
            Mana = Maxmana;
            Level = 1;
            ScoreMultiplier = 1;
            Xp = 0;

            int ZombieScore;
            ZombieScore = 50;
            int ZombieXP;
            ZombieXP = 10;
            int ZombieDamage;
            ZombieDamage = 5;
            

            
            ShowHud();
            
            Console.WriteLine(Name + " enter's the dark crypt.");
            Console.WriteLine("He skulks down the steps and encounters a Zombie!");
            Console.WriteLine("");
            Console.WriteLine(Name + "swings his claymore into the zombies side");
            Console.WriteLine("Zombie falls");
            Console.WriteLine(Name + " gains " + ZombieScore + " points and " + ZombieXP + " experience");
            Console.WriteLine("");

            ShowHud();

            Console.ReadKey(true);
        }
    }
}
