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
        static float ScoreMultiplier = 1;
        static float Score;
        static string Name;
        static float Soul = 1.5f;



        static void ShowHud()
        {
            Console.WriteLine("============================");
            Console.WriteLine(" " + Name + "  Score:" + Score);
            Console.WriteLine(" HP:" + Health + "/" + Maxhealth + " " + "MP:" + Mana + "/" + Maxmana);
            Console.WriteLine(" Lvl:" + Level + " " + "Xp:" + Xp + " Soul Power:" + ScoreMultiplier);
            Console.WriteLine("============================");

        }

        static void TakeDamage(int Damage)
        {
            Health = Health - Damage;
        }

        static void AddScore(float ScoreAdd, float Multiplier)
        {
            Score = Score + ScoreAdd * Multiplier;
        }

        static void ManaUse(int UseMana)
        {
            Mana = Mana - UseMana;
        }

        static void XpGain(int addXP)
        {
            Xp = Xp + addXP;
        }

        static void LevelUp()
        {
            Xp = Xp - 100;
            Level = Level + 1;
            Maxhealth = Maxhealth + 25;
            Maxmana = Maxmana + 20;
            Health = Maxhealth;
            Mana = Maxmana;
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
            Xp = 0;

            float ZombieScore = 50;
            int ZombieXP = 10;
            int ZombieDamage = 5;
            int Fireball = 8;
            float MummyScore = 200;
            int MummyXp = 40;
            int MummyDamage = 20;
           
            ShowHud();
            
            Console.WriteLine(Name + " enter's the dark crypt.");
            Console.WriteLine("He skulks down the steps and encounters a Zombie!");
            Console.WriteLine("");
            Console.WriteLine(Name + "swings his claymore into the zombies side");
            Console.WriteLine("Zombie falls");
            Console.WriteLine(Name + " gains " + ZombieScore + " points and " + ZombieXP + " experience");
            AddScore(ZombieScore, ScoreMultiplier);
            XpGain(ZombieXP); 
            Console.WriteLine("");

            ShowHud();

            Console.WriteLine("");
            Console.WriteLine(Name + " delves deeper into the crypt");
            Console.WriteLine(Name + " encounters three zombies!");
            Console.WriteLine("");
            Console.WriteLine("Zombie strikes!");
            Console.WriteLine(Name + " takes " + ZombieDamage + " damage!");
            TakeDamage(ZombieDamage);
            Console.WriteLine("");
            Console.WriteLine("Zombie strikes!");
            Console.WriteLine(Name + " dodges the attack!");
            Console.WriteLine("");
            Console.WriteLine("Zombie strikes!");
            Console.WriteLine(Name + " takes " + ZombieDamage + " damage!");
            TakeDamage(ZombieDamage);
            Console.WriteLine("");
            Console.WriteLine(Name + " casts fireball for " + Fireball + " mana");
            Console.WriteLine("Zombie is incinerated!");
            Console.WriteLine(Name + " gains " + ZombieScore + " x " + ScoreMultiplier + " points and " + ZombieXP + " experience");
            AddScore(ZombieScore, ScoreMultiplier);
            XpGain(ZombieXP);
            ManaUse(Fireball);
            Console.WriteLine("");

            ShowHud();

            Console.WriteLine("");
            Console.WriteLine("Zombie strikes!");
            Console.WriteLine(Name + " dodges the attack!");
            Console.WriteLine("");
            Console.WriteLine("Zombie strikes!");
            Console.WriteLine(Name + " takes " + ZombieDamage + " damage!");
            TakeDamage(ZombieDamage);
            Console.WriteLine("");
            Console.WriteLine(Name + " swings his claymore");
            Console.WriteLine("Zombie Falls");
            Console.WriteLine("Zombie Dropped a Soul Fragment! New score is now multiplied by " + Soul);
            ScoreMultiplier = ScoreMultiplier * Soul;
            Console.WriteLine(Name + " gains " + ZombieScore + " x " + ScoreMultiplier + " points and " + ZombieXP + " experience");
            Console.WriteLine("");
            AddScore(ZombieScore, ScoreMultiplier);
            XpGain(ZombieXP);

            ShowHud();

            Console.WriteLine("");
            Console.WriteLine("Zombie shuffles forward");
            Console.WriteLine("");
            Console.WriteLine(Name + " casts fireball for " + Fireball + " mana");
            Console.WriteLine("Zombie is incinerated!");
            Console.WriteLine(Name + " gains " + ZombieScore + " x " + ScoreMultiplier + " points and " + ZombieXP + " experience");
            AddScore(ZombieScore, ScoreMultiplier);
            ManaUse(Fireball);
            XpGain(ZombieXP);
            Console.WriteLine("");

            ShowHud();

            Console.WriteLine("");
            Console.WriteLine(Name + " enters a large room, in the middle there are two coffins");
            Console.WriteLine("");
            Console.WriteLine("Two mummies emerge from the coffins");
            Console.WriteLine("");
            Console.WriteLine("Mummy Attacks");
            Console.WriteLine(Name + " takes " + MummyDamage + " damage!");
            TakeDamage(MummyDamage);
            Console.WriteLine("Mummy Attacks");
            Console.WriteLine(Name + " dodges the attack");
            Console.WriteLine("");
            Console.WriteLine(Name + " casts fireball for " + Fireball + " mana");
            Console.WriteLine("Mummy is incinerated!");
            Console.WriteLine(Name + " gains " + MummyScore + " x " + ScoreMultiplier + " points and " + MummyXp + " experience");
            ManaUse(Fireball);
            AddScore(MummyScore, ScoreMultiplier);
            XpGain(MummyXp);
            Console.WriteLine("");

            ShowHud();

            Console.WriteLine("");
            Console.WriteLine("Mummy Attacks");
            Console.WriteLine(Name + " takes " + MummyDamage + " damage!");
            TakeDamage(MummyDamage);
            Console.WriteLine("");
            Console.WriteLine(Name + " swings his claymore");
            Console.WriteLine("Mummy falls!");
            Console.WriteLine(Name + " gains " + MummyScore + " x " + ScoreMultiplier + " points and " + MummyXp + " experience");
            Console.WriteLine("");
            Console.WriteLine(Name + " levels up!");
            Console.WriteLine(Name + " now has an extra 25 HP, and 20 MP!");
            Console.WriteLine(Name + "'s Health and mana have been restored!");
            AddScore(MummyScore, ScoreMultiplier);
            XpGain(MummyXp);
            LevelUp();
            Console.WriteLine("");
            
            ShowHud();

            Console.WriteLine("");
            Console.WriteLine(Name + " finds the ancient chest and collected the quest reward!");
            Console.WriteLine(Name + " has collected the ancient amulet of The Reaper");

            Console.ReadKey(true);
        }
    }
}
