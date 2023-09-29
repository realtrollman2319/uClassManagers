using System;
using uScript.API.Attributes;

namespace uClassManagers.Extras.uDateTime
{
    [ScriptClass("TimeSpan")]
    public class TimeSpanClass
    {
        public TimeSpan timeSpan { get; private set; }
        public TimeSpanClass(TimeSpan c_timeSpan) => timeSpan = c_timeSpan;

        [ScriptConstructor]
        public TimeSpanClass(double ticks)
        {
            timeSpan = new TimeSpan((long)ticks);
        }

        [ScriptConstructor]
        public TimeSpanClass(int hours, int minutes, int seconds)
        {
            timeSpan = new TimeSpan(hours, minutes, seconds);
        }

        [ScriptConstructor]
        public TimeSpanClass(int days, int hours, int minutes, int seconds)
        {
            timeSpan = new TimeSpan(days, hours, minutes, seconds);
        }

        [ScriptConstructor]
        public TimeSpanClass(int days, int hours, int minutes, int seconds, int milliseconds)
        {
            timeSpan = new TimeSpan(days, hours, minutes, seconds, milliseconds);
        }

        [ScriptFunction("toString")]
        public override string ToString() => timeSpan.ToString("yyyy-MM-dd HH:mm:ss");

        [ScriptFunction("toString")]
        public string ToString(string format) => timeSpan.ToString(format);

        [ScriptFunction("subtract")]
        public TimeSpanClass Subtract(TimeSpanClass timeSpawn) => new TimeSpanClass(timeSpan.Subtract(timeSpawn.timeSpan));

        [ScriptProperty("ticksPerMillisecond")]
        public static double TicksPerMillisecond => TimeSpan.TicksPerMillisecond;

        [ScriptProperty("ticksPerSecond")]
        public static double TicksPerSecond => TimeSpan.TicksPerSecond;

        [ScriptProperty("ticksPerMinute")]
        public static double TicksPerMinute => TimeSpan.TicksPerMinute;

        [ScriptProperty("ticksPerHour")]
        public static double TicksPerHour => TimeSpan.TicksPerHour;

        [ScriptProperty("ticksPerDay")]
        public static double TicksPerDay => TimeSpan.TicksPerDay;

        [ScriptProperty("zero")]
        public static TimeSpanClass Zero => new TimeSpanClass(TimeSpan.Zero);

        [ScriptProperty("maxValue")]
        public static TimeSpanClass MaxValue => new TimeSpanClass(TimeSpan.MaxValue);

        [ScriptProperty("minValue")]
        public static TimeSpanClass MinValue => new TimeSpanClass(TimeSpan.MinValue);

        [ScriptProperty("totalDays")]
        public double TotalDays => timeSpan.TotalDays;

        [ScriptProperty("totalHours")]
        public double TotalHours => timeSpan.TotalHours;

        [ScriptProperty("totalMinutes")]
        public double TotalMinutes => timeSpan.TotalMinutes;

        [ScriptProperty("totalSeconds")]
        public double TotalSeconds => timeSpan.TotalSeconds;

        [ScriptProperty("totalMilliseconds")]
        public double TotalMilliseconds => timeSpan.TotalMilliseconds;

        [ScriptProperty("days")]
        public int Days => timeSpan.Days;

        [ScriptProperty("hours")]
        public int Hours => timeSpan.Hours;

        [ScriptProperty("minutes")]
        public int Minutes => timeSpan.Minutes;

        [ScriptProperty("seconds")]
        public int Seconds => timeSpan.Seconds;

        [ScriptProperty("milliseconds")]
        public int Milliseconds => timeSpan.Milliseconds;

        [ScriptProperty("ticks")]
        public double Ticks => timeSpan.Ticks;
    }
}
