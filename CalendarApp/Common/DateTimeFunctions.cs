namespace CalendarApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;


// Renamed class to avoid conflict with System.DateTime
public static class DateTimeFunctions {
    public static string ToMMMMyyyy(this System.DateTime dateTime) =>
        dateTime.ToString("MMMM yyyy");

    public static
    IEnumerable<System.DateTime> GetDaysWithinWeeks(this System.DateTime dateTime, int weeksCount) {
        var resultDaysCount = 7 * weeksCount;

        var firstDayOfMonth = new System.DateTime(dateTime.Year, dateTime.Month, 1);
        while (firstDayOfMonth.DayOfWeek != DayOfWeek.Monday)
            firstDayOfMonth = firstDayOfMonth.AddDays(-1);

        foreach (var i in Enumerable.Range(0, resultDaysCount)) {
            yield return firstDayOfMonth.AddDays(i);
        }
    }
}

