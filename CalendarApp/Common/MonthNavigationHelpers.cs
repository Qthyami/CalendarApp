namespace CalendarApp.Common;

public static class MonthNavigationHelpers
{
    public static DateTime GetStartYear(DateTime selectedMonthStartDate)
    {
        var thisYearStart = new DateTime(selectedMonthStartDate.Year, 1, 1);
        if (selectedMonthStartDate.Date == thisYearStart.Date) {
            thisYearStart = thisYearStart.AddYears(-1);
        }
        return thisYearStart;
    }

    public static DateTime GetEndYear(DateTime selectedMonthStartDate)
    {
        var endYear = new DateTime(selectedMonthStartDate.Year, 12, 1);
        if (selectedMonthStartDate.Date == endYear.Date) {
            endYear = endYear.AddYears(1);
        }
        return endYear;
    }
}
