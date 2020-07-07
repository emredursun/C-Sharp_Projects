using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_SnailRace
{
    class Snail
    {
        #region Fields - Instance variables
        public string SnailName { get; set; }
        public int MinSpeed { get; set; }
        public int MaxSpeed { get; set; }
        #endregion

        #region Constructors
        // Default snail instance variables
        public Snail()
        {
            SnailName = "Junior Snail";
            MinSpeed = 5;
            MaxSpeed = 50;
        }

        // Constructor to create new snails
        public Snail(string snailName, int minSpeed, int maxSpeed)
        {
            SnailName = snailName;
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
        }
        #endregion

        #region Methods
        // Override method for ToString to add text
        public override string ToString()
        {
            return "Snail " + SnailName;
        }
        #endregion
    }
}
