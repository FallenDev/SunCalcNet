using System;
using System.Collections.Generic;

namespace SunCalcNet.Model
{
    [Serializable]
    public class SunPhaseName
    {
        private SunPhaseName(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static SunPhaseName SolarNoon => new("Solar Noon");
        public static SunPhaseName Nadir => new("Nadir");
        public static SunPhaseName Sunrise => new("Sunrise");
        public static SunPhaseName Sunset => new("Sunset");
        public static SunPhaseName SunriseEnd => new("Sunrise End");
        public static SunPhaseName SunsetStart => new("Sunset Start");
        public static SunPhaseName Dawn => new("Dawn");
        public static SunPhaseName Dusk => new("Dusk");
        public static SunPhaseName NauticalDawn => new("Nautical Dawn");
        public static SunPhaseName NauticalDusk => new("Nautical Dusk");
        public static SunPhaseName NightEnd => new("Night End");
        public static SunPhaseName Night => new("Night");
        public static SunPhaseName GoldenHourEnd => new("Golden Hour End");
        public static SunPhaseName GoldenHour => new("Golden Hour");

        public override string ToString()
        {
            return Value;
        }
    }

    [Serializable]
    public class SunPhaseAngle
    {
        public double Angle { get; }

        public SunPhaseName RiseName { get; }

        public SunPhaseName SetName { get; }

        private SunPhaseAngle(double angle, SunPhaseName riseName, SunPhaseName setName)
        {
            Angle = angle;
            RiseName = riseName;
            SetName = setName;
        }

        public static IEnumerable<SunPhaseAngle> List => [new(-0.833, SunPhaseName.Sunrise, SunPhaseName.Sunset),
            new(-0.3, SunPhaseName.SunriseEnd, SunPhaseName.SunsetStart), 
            new(-6, SunPhaseName.Dawn, SunPhaseName.Dusk), 
            new(-12, SunPhaseName.NauticalDawn, SunPhaseName.NauticalDusk), 
            new(-18, SunPhaseName.NightEnd, SunPhaseName.Night), 
            new(6, SunPhaseName.GoldenHourEnd, SunPhaseName.GoldenHour)];
    }
}