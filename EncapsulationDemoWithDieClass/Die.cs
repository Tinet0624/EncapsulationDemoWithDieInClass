using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
    /// <summary>
    /// Represents an individual dice
    /// </summary>
    class Die
    {
        // Static fields are shared across all die classes
        static Random rand;
        byte minValue;
        byte maxValue;

        // Static constructors are only called once for all die classes.
        // Only sets random one time
        static Die()
        {
            rand = new Random();
        }

        /// <summary>
        /// Standard 6 sided die
        /// </summary>
        public Die():this(1, 6)
        {
        }

        /// <summary>
        /// Creates a die with #'s between min and max values
        /// </summary>
        /// <param name="minValue">The inclusive lower bound</param>
        /// <param name="maxValue">The inclusive max bound</param>
        public Die(byte minValue, byte maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            Roll();// Roll die on creation to generate 1st random number
        }
        /// <summary>
        /// Face up Value of die
        /// </summary>
        public byte Value { get; private set; } // put private on set to make that one private.

        /// <summary>
        /// Wether or not some one holds the die
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls a new random value between 1 - 6
        /// and returns the newly rolled value.
        /// If the die is held the, the current value will be returned
        /// and no new value generated.
        /// </summary>
        public byte Roll()
        {
            if (!IsHeld)
            {
                //add 1 to max value due to upper bound being exclusive.
                Value = (byte)rand.Next(minValue, maxValue + 1); 
            }
            return Value;
        }
    }
}
