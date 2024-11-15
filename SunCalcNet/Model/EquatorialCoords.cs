﻿using System;

namespace SunCalcNet.Model
{
    [Serializable]
    public struct EquatorialCoords(double rightAscension, double declination) : IEquatable<EquatorialCoords>
    {
        public double RightAscension { get; } = rightAscension;

        public double Declination { get; } = declination;

        public static bool operator ==(EquatorialCoords lhs, EquatorialCoords rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(EquatorialCoords lhs, EquatorialCoords rhs)
        {
            return !(lhs == rhs);
        }

        public bool Equals(EquatorialCoords other)
        {
            return RightAscension == other.RightAscension
                   && Declination == other.Declination;
        }

        public override bool Equals(object obj)
        {
            if (obj is EquatorialCoords coords)
            {
                return Equals(coords);
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (RightAscension.GetHashCode() * 397) ^ Declination.GetHashCode();
            }
        }
    }
}