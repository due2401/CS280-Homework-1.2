using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon Pokemon = new Pokemon();
            Pokemon.Number = "#078";
            Pokemon.Name = "Rapidash";
            Pokemon.Height = 5.0f;
            Pokemon.Weight = 209.4f;
            Pokemon.Abilities = "Flash Fire";
            Pokemon.Categroy = "Fire Horse";
            Pokemon.Gender = "F";
            Console.WriteLine("編號: {0}", Pokemon.Number);
            Console.WriteLine("名稱: {0}", Pokemon.Name);
            Console.WriteLine("身高: {0} 尺", Pokemon.Height);
            Console.WriteLine("體重: {0} 磅", Pokemon.Weight);
            Console.WriteLine("技能: {0}", Pokemon.Abilities);
            Console.WriteLine("種類: {0}", Pokemon.Categroy);
            Console.WriteLine("性別: {0}", Pokemon.Gender);
        }
    }
}