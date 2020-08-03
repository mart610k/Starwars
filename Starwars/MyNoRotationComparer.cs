using System.Collections.Generic;

namespace Starwars
{
    class MyNoRotationComparer : IEqualityComparer<Planet>
    {
        public bool Equals(Planet x, Planet y)
        {
            if (x.RotationPeriod > 0)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Planet obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
