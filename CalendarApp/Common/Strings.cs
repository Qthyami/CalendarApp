namespace CalendarApp.Common;

public static class Strings {
        public static string 
    AddWordIf(this string @string, bool condition, string word) {
        if (condition) {
            return @string.AddWord(word);
        }
        return @string;
    } 

    public static string 
    AddWord(this string @string, string word) {
        if (string.IsNullOrEmpty(@string))
            return word;
        return $"{@string} {word}";
    }

}
