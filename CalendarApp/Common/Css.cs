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

    public static string
      Combine(string baseClass, params string[] modifiers) {
        var all = new List<string> { baseClass };
        all.AddRange(modifiers.Where(modifier => !string.IsNullOrWhiteSpace(modifier))
        .Select(modifier => $"{baseClass}{modifier}")); 
        return string.Join(" ", all);
    }
}
