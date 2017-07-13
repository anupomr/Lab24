using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 
 * Name: Anupom Roy
 * Date: July 13, 2017 
 * Description: This is the SuperHero class which inherits from the SuperHuman class
 * and implements the IHasKarma Interface
 * Version: 0.3 - Fixed Constructor error 
 */
namespace com123_Lesson09A
{
    /// <summary>
    /// this is main constrator
    /// </summary>
    public class SuperHero: SuperHuman, IHasKarma
    {
        //Private Instance Variable
        private int _karma;
        //Public properties
        public int Karma
        {
            get
            { return this._karma; }
            set
            { this._karma=value; }
        }
        //Constractior
        /// <summary>
        /// /// <summary>
        /// this is main constrator
        /// </summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        public SuperHero(string name, int karma )
            :base(name)
        {
            this.Karma = karma;
        }
        //private 
    }
}