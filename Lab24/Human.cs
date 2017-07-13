using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name: Anupom
Date: 11 July 2017
Description: This is the abstract class Human which other subclasses will
 derive from.
Version: 0.2 - Added Public Abstract method DisplaySkills
*/

namespace com123_Lesson09A
{
    /// <summary>
    /// This is the Human Abstract class
    /// </summary>
    public abstract class Human
    {
        //Private Fields
        private string _name;


        // Public properties
        public string Name
        {
            get
            {

                return this._name;
            }

            set
            {
                this._name = value;
            }
        }
        // constract-----------------
        /// <summary>
        /// This is the constructor for the Human abstract class.
        /// It requires one parameter - name (string).
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        // PUBLIC ABSTRACT METHODS
        public abstract void DisplaySkill();
    }
}