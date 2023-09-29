using System;
using uScript.API.Attributes;
using uScript.Module.Main.Classes;

namespace uClassManagers.Extras.uDateTime
{
    [ScriptClass("DateTimeOffset")]
    public class DateTimeOffsetClass
    {
        public DateTimeOffset dateTimeOffset { get; private set; }
        public DateTimeOffsetClass(DateTimeOffset c_dateTimeOffset) => dateTimeOffset = c_dateTimeOffset;

        [ScriptConstructor]
        public DateTimeOffsetClass(double seconds)
        {
            dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)seconds);
        }

        [ScriptConstructor]
        public DateTimeOffsetClass(DateTimeClass dateTimeClass)
        {
            dateTimeOffset = new DateTimeOffset(dateTimeClass.DateTime);
        }

        [ScriptConstructor]
        public DateTimeOffsetClass(double ticks, TimeSpanClass offset)
        {
            dateTimeOffset = new DateTimeOffset((long)ticks, offset.timeSpan);
        }

        [ScriptConstructor]
        public DateTimeOffsetClass(DateTimeClass dateTimeClass, TimeSpanClass offset)
        {
            dateTimeOffset = new DateTimeOffset(dateTimeClass.DateTime, offset.timeSpan);
        }

        [ScriptConstructor]
        public DateTimeOffsetClass(int year, int month, int day, int hour, int minute, int second, TimeSpanClass offset)
        {
            dateTimeOffset = new DateTimeOffset(year, month, day, hour, minute, second, offset.timeSpan);
        }

        [ScriptConstructor]
        public DateTimeOffsetClass(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpanClass offset)
        {
            dateTimeOffset = new DateTimeOffset(year, month, day, hour, minute, second, millisecond, offset.timeSpan);
        }

        [ScriptProperty("dateTime")]
        public DateTimeClass DateTime => new DateTimeClass(dateTimeOffset.DateTime);

        [ScriptFunction("toString")]
        public override string ToString() => dateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss");

        [ScriptFunction("toString")]
        public string ToString(string format) => dateTimeOffset.ToString(format);

        [ScriptFunction("toUnixTimeSeconds")]
        public double ToUnixTimeSeconds()
        {
            return dateTimeOffset.ToUnixTimeSeconds();
        }

        [ScriptFunction("toUnixTimeMilliseconds")]
        public double ToUnixTimeMilliseconds()
        {
            return dateTimeOffset.ToUnixTimeMilliseconds();
        }

        [ScriptProperty("year")]
        public int Year => dateTimeOffset.Year;

        [ScriptProperty("month")]
        public int Month => dateTimeOffset.Month;

        [ScriptProperty("day")]
        public int Day => dateTimeOffset.Day;

        [ScriptProperty("dayOfYear")]
        public int DayOfYear => dateTimeOffset.DayOfYear;

        [ScriptProperty("hour")]
        public int Hour => dateTimeOffset.Hour;

        [ScriptProperty("minute")]
        public int Minute => dateTimeOffset.Minute;

        [ScriptProperty("second")]
        public int Second => dateTimeOffset.Second;

        [ScriptProperty("millisecond")]
        public int Millisecond => dateTimeOffset.Millisecond;

        [ScriptProperty("ticks")]
        public double Ticks => dateTimeOffset.Ticks;

        [ScriptProperty("totalDays")]
        public double TotalDays => dateTimeOffset.Ticks / 864000000000L;

        [ScriptProperty("totalHours")]
        public double TotalHours => dateTimeOffset.Ticks / 36000000000L;

        [ScriptProperty("totalMinutes")]
        public double TotalMinutes => dateTimeOffset.Ticks / 600000000L;

        [ScriptProperty("totalSeconds")]
        public double TotalSeconds => dateTimeOffset.Ticks / 10000000L;

        [ScriptProperty("totalMilliseconds")]
        public double TotalMilliseconds => dateTimeOffset.Ticks / 10000L;

        [ScriptFunction("add")]
        public DateTimeOffsetClass Add(TimeSpanClass timeSpan) => new DateTimeOffsetClass(dateTimeOffset.Add(timeSpan.timeSpan));

        [ScriptFunction("addYears")]
        public DateTimeOffsetClass AddYears(int years) => new DateTimeOffsetClass(dateTimeOffset.AddYears(years));

        [ScriptFunction("addMonths")]
        public DateTimeOffsetClass AddMonths(int months) => new DateTimeOffsetClass(dateTimeOffset.AddMonths(months));

        [ScriptFunction("addDays")]
        public DateTimeOffsetClass AddDays(double days) => new DateTimeOffsetClass(dateTimeOffset.AddDays(days));

        [ScriptFunction("addHours")]
        public DateTimeOffsetClass AddHours(double hours) => new DateTimeOffsetClass(dateTimeOffset.AddHours(hours));

        [ScriptFunction("addMinutes")]
        public DateTimeOffsetClass AddMinutes(double minutes) => new DateTimeOffsetClass(dateTimeOffset.AddMinutes(minutes));

        [ScriptFunction("addSeconds")]
        public DateTimeOffsetClass AddSeconds(double seconds) => new DateTimeOffsetClass(dateTimeOffset.AddSeconds(seconds));

        [ScriptFunction("addMilliseconds")]
        public DateTimeOffsetClass AddMilliseconds(double milliseconds) => new DateTimeOffsetClass(dateTimeOffset.AddMilliseconds(milliseconds));

        [ScriptFunction("addTicks")]
        public DateTimeOffsetClass AddTicks(double ticks) => new DateTimeOffsetClass(dateTimeOffset.AddTicks((long)ticks));
    }
}
