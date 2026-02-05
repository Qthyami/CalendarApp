namespace CalendarApp.Common;

public static class MonthNavigationHelpers {
    public static DateTime
    GetStartYear(this DateTime selectedMonthStartDate) {
        var yearStart = new DateTime(selectedMonthStartDate.Year, 1, 1);
        if (selectedMonthStartDate.Date == yearStart.Date) {
            yearStart = yearStart.AddYears(-1);
        }
        return yearStart;
    }

    public static DateTime
    GetEndYear(this DateTime selectedMonthStartDate) {
        var endYear = new DateTime(selectedMonthStartDate.Year, 12, 1);
        if (selectedMonthStartDate.Date == endYear.Date) {
            endYear = endYear.AddYears(1);
        }
        return endYear;
    }
}
