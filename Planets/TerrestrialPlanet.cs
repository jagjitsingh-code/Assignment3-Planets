using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        /// <summary>
        ///     <Author>jagjit singh</Author>
        ///     <StudentID>301106044</StudentID>
        ///     <DateModified>22-07-2020</DateModified>
        ///     <Decription>this is terrestrialplant</Decription>
        ///     <RevisionHistory></RevisionHistory>
        /// </summary>

        //Private instance variables
        //--------------------------------
        private bool _oxygen;


        //Constructor
        //--------------------------------
        public TerrestrialPlanet(string name, bool oxygen, double diameter, double mass) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }


        //Public Methods
        //--------------------------------
        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        public bool Habitable()
        {
            if (_oxygen)
                return true;
            else
                return false;
        }
    }
}
