using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FishvsSharks
{
    class FlopFish : Fish
    {
        public const string UNIT_TYPE = "Flop fish";
        private const int CURRENT_HEALTH = 2;
        private const int MAXIMUM_HEALTH = 2;
        private const int REQUIRED_WATERPOWER = 2;

        public FlopFish() : base (UNIT_TYPE, CURRENT_HEALTH, MAXIMUM_HEALTH, REQUIRED_WATERPOWER)
        {
            fishImage = Properties.Resources.flopfish;
            
        }

       
        public override Fish CreateFish()
        {
            return new FlopFish();
        }
    }
}
