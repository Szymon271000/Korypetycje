using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DateTime
{
    public struct TimePeriod: IEquatable<TimePeriod>, IComparable<TimePeriod>
    {
        public long PeriodTimeSeconds { get; }

        public TimePeriod(int hours, byte minutes, byte seconds)
        {
            if (hours < 0 ||!Time.CheckMinutes(minutes) || !Time.CheckSeconds(seconds))
            {
                throw new ArgumentException();
            }
            PeriodTimeSeconds = hours * 3600 + minutes * 60 + seconds;
        }

        public TimePeriod(string TimeStr)
        {
            if (!Regex.IsMatch(TimeStr, @"$[0-9]+:[0-5][0-9]:[0-5][0-9]^"))
            {
                throw new FormatException();
            }
            string[] TimeFormat = TimeStr.Split(":");
            int HoursFromString = int.Parse(TimeFormat[0]);
            byte MinutesFromString = byte.Parse(TimeFormat[0]);
            byte SecondsFromString = byte.Parse(TimeFormat[0]);
            if (HoursFromString < 0 || !Time.CheckMinutes(MinutesFromString) || !Time.CheckSeconds(SecondsFromString))
            {
                throw new ArgumentException();
            }
            PeriodTimeSeconds = HoursFromString * 3600 + MinutesFromString * 60 + SecondsFromString;
        }

        private TimePeriod (long TotalSeconds)
        {
            PeriodTimeSeconds = TotalSeconds;
        }

        public override string? ToString()
        {
            long hours = PeriodTimeSeconds / 3600;
            long minutes = (PeriodTimeSeconds - hours * 3600) / 60;
            long seconds = PeriodTimeSeconds % 60;
            return $"{hours}:{minutes:00}:{seconds:00}";
        }

        public bool Equals(TimePeriod other)
        {
            return this.PeriodTimeSeconds == other.PeriodTimeSeconds;
        }

        public int CompareTo(TimePeriod other)
        {
            return this.PeriodTimeSeconds.CompareTo(other.PeriodTimeSeconds);
        }

        public static bool operator ==(TimePeriod t1, TimePeriod t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(TimePeriod t1, TimePeriod t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(TimePeriod t1, TimePeriod t2)
        {
            return t1.PeriodTimeSeconds < t2.PeriodTimeSeconds;
        }

        public static bool operator >(TimePeriod t1, TimePeriod t2)
        {
            return t1.PeriodTimeSeconds > t2.PeriodTimeSeconds;
        }

        public static bool operator <=(TimePeriod t1, TimePeriod t2)
        {
            return t1.PeriodTimeSeconds <= t2.PeriodTimeSeconds;
        }

        public static bool operator >=(TimePeriod t1, TimePeriod t2)
        {
            return t1.PeriodTimeSeconds >= t2.PeriodTimeSeconds;
        }

        public static TimePeriod operator + (TimePeriod t1, TimePeriod t2)
        {
            return new TimePeriod(t1.PeriodTimeSeconds + t2.PeriodTimeSeconds);
        }

        public static TimePeriod operator - (TimePeriod t1, TimePeriod t2)
        {
            if (t1.PeriodTimeSeconds < t2.PeriodTimeSeconds)
                throw new InvalidOperationException();
            return new TimePeriod(t1.PeriodTimeSeconds - t2.PeriodTimeSeconds);
        }
    }
}
