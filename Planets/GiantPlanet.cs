using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        /// <summary>
        ///     <Author>jagjit singh</Author>
        ///     <StudentID>301106044</StudentID>
        ///     <DateModified>22-07-2020</DateModified>
        ///     <Decription>this is giantplanet</Decription>
        ///     <RevisionHistory></RevisionHistory>
        /// </summary>


        //Private instance variables
        //--------------------------------
        private string _type;


        //Constructor
        //--------------------------------
        public GiantPlanet(string name, string type, double diameter, double mass) : base(name, diameter, mass)
        {
            _type = type;
        }


        //Public Methods
        //---------------------------------
        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        public bool HasRings()
        {
            if (RingCount > 0)
                return true;
            else
                return false;
        }
    }
}
