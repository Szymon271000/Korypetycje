using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DateTime
{
    public struct Time : IComparable<Time>, IEquatable<Time>
    {
        private readonly byte hours;
        private readonly byte minutes;
        private readonly byte seconds;

        private int TotalSeconds => hours * 3600 + minutes * 60 + seconds;

        public Time(byte hours = 0, byte minutes = 0, byte seconds = 0)
        {
            if (!CheckHours(hours) || !CheckMinutes(minutes) || !CheckSeconds(seconds))
            {
                throw new ArgumentException();
            }
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Time(string TimeStr)
        {
            if (!Regex.IsMatch(TimeStr, @"$[0-2][0-9]:[0-5][0-9]:[0-5][0-9]^"))
            {
                throw new FormatException();
            }
            string[] TimeFormat = TimeStr.Split(":");
            byte HoursFromString = byte.Parse(TimeFormat[0]);
            byte MinutesFromString = byte.Parse(TimeFormat[0]);
            byte SecondsFromString = byte.Parse(TimeFormat[0]);
            if (!CheckHours(HoursFromString) || !CheckMinutes(MinutesFromString) || !CheckSeconds(SecondsFromString))
            {
                throw new ArgumentException();
            }
            this.hours = HoursFromString;
            this.minutes = MinutesFromString;
            this.seconds = SecondsFromString;
        }

        private Time (long TotalSeconds)
        {
             hours = ((byte)(TotalSeconds / 3600));
             minutes = ((byte)((TotalSeconds - hours * 3600) / 60));
             seconds = (byte)(TotalSeconds % 60);
        }

        public byte Hours => hours;

        public byte Minutes => minutes;

        public byte Seconds => seconds;

        public static bool CheckHours(byte hours)
        {
            return hours >= 0 && hours <= 23;
        }

        public static bool CheckMinutes(byte minutes)
        {
            return minutes >= 0 && minutes <= 59;
        }

        public static bool CheckSeconds(byte seconds)
        {
            return seconds >= 0 && seconds <= 59;
        }

        public override string? ToString()
        {
            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }

        public int CompareTo(Time other)
        {
            return TotalSeconds.CompareTo(other.TotalSeconds);
        }

        public bool Equals(Time other)
        {
            return CompareTo(other) == 0;
        }

        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }

        public static bool operator < (Time t1, Time t2)
        {
            return t1.TotalSeconds < t2.TotalSeconds;
        }

        public static bool operator >(Time t1, Time t2)
        {
            return t1.TotalSeconds > t2.TotalSeconds;
        }

        public static bool operator <=(Time t1, Time t2)
        {
            return t1.TotalSeconds <= t2.TotalSeconds;
        }

        public static bool operator >=(Time t1, Time t2)
        {
            return t1.TotalSeconds >= t2.TotalSeconds;
        }

        public static Time operator +(Time t1, TimePeriod t2)
        {
            return new Time(t1.TotalSeconds + t2.PeriodTimeSeconds);
        }
    }
}
