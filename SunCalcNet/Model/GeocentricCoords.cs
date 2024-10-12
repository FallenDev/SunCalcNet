using System;

namespace SunCalcNet.Model
{
    [Serializable]
    public struct GeocentricCoords(double rightAscension, double declination, double distance)  : IEquatable<GeocentricCoords>
    {
        public double RightAscension { get; } = rightAscension;

        public double Declination { get; } = declination;

        public double Distance { get; } = distance;

        public static bool operator ==(GeocentricCoords lhs, GeocentricCoords rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(GeocentricCoords lhs, GeocentricCoords rhs)
        {
            return !(lhs == rhs);
        }

        public bool Equals(GeocentricCoords other)
        {
            return RightAscension == other.RightAscension
                   && Declination == other.Declination
                   && Distance == other.Distance;
        }

        public override bool Equals(object obj)
        {
            if (obj is GeocentricCoords coords)
            {
                return Equals(coords);
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = RightAscension.GetHashCode();
                hashCode = (hashCode * 397) ^ Declination.GetHashCode();
                return (hashCode * 397) ^ Distance.GetHashCode();
            }
        }
    }
}