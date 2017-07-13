using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Name: Anupom
Date: 11 July 2017
Description: This is the driver class for my project
Version: 0.3 - Used the ToString Method of the SuperHuman class
 */
namespace com123_Lesson09A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Teleportation", 50));
            superHuman.Powers.Add(new Power("Phasing", 40));
            superHuman.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHuman.ToString());

            SuperVillain superVillian = new SuperVillain("Super Dude",20);
            superVillian.Powers.Add(new Power("Spiderclimbing",50));
            superVillian.Powers.Add(new Power("Teleportation", 30));
            
            Console.WriteLine(superVillian.ToString());
        }
    }
}
