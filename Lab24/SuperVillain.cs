using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 
 * Name: Anupom Roy
 * Date: July 13, 2017 
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * and implements the IHasMalice Interface
 * Version: 0.1 - Create  SuperVillain class
 */
namespace com123_Lesson09A
{
    /// <summary>
    /// This is the SuperVillain sub class.
    /// It inherits from the SuperHuman Superclass.
    /// </summary>
    public class SuperVillain :SuperHuman, IHasMalice
    {
        //Private Instance Variable
        private int _malice;
        //Public properties
        public int Malice
        {
            get
            { return this._malice; }
            set
            { this._malice = value; }
        }
        //Constractior
        /// <summary>
        /// /// <summary>
        /// this is main constrator
        /// </summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        public SuperVillain(string name, int malice)
            :base(name)
        {
            this.Malice = malice;
        }
        public override string ToString()
        {
            return string.Format("Malice points  : {0}",Malice);
        }
        //private 
    }
}