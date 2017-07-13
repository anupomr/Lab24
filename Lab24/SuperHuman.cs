using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Name: Anupom
Date: 11 July 2017
Description: This is the SuperHuman sub class.
Version: 0.5 - Added Stub Method DisplaySkills to conform to Human Abstract Superclass
*/
namespace com123_Lesson09A
{
    /// <summary>
    /// This is the SuperHuman sub class.
    /// It inherits from the Human Superclass.
    /// </summary>
    public class SuperHuman : Human
    {
        // private fields
        private List<Power> _powers;
        // Public properties
        public List<Power> Powers {
            get
            {
                return this._powers;
            }
             }

        // constract-----------------
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        //Private mathod
        /// <summary>
        ///  This method initializes and assigns default values to Class Fields
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }
        // PUBLIC METHODS

        /// <summary>
        /// This method adds a Power to the Power List
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        public void DisplayPower()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("Name : "+power.Name+"Rank"+ power.Rank);
            }
        }
        // PUBLIC OVERRIDDEN METHODS

        /// <summary>
        /// Overridden the built-in ToString method
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public override string  ToString() {
            string outputString="";
            outputString += "========================================================\n";
            outputString += "Super humen Name " + this.Name + "\n";
            outputString += "========================================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power:" + power.Name + " Rank :  " + power.Rank + "\n";
            }
            return outputString;
        }
        /// <summary>
        /// This is the DisplaySkills Method.
        /// NEEDS TO BE IMPLEMENTED...
        /// </summary>
        public override void DisplaySkill()
        {
            Console.WriteLine("Not implemented");
        }
    }
}