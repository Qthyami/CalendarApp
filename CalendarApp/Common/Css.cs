namespace CalendarApp.Common;

public static class Css {
     public static string 
    T(this bool value, string @class) {
        if (value)
            return @class;
        return string.Empty;
    }

    public static string 
    F(this bool value, string @class) {
        if (!value) return @class;
        return string.Empty;
    }
}
