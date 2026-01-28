namespace CalendarApp;

public class CalendarState
{
    public DateTime SelectedDate { get; private set; } = DateTime.Today;
    public event Action? OnChange;

    public void
    SetDate(DateTime date){
        if (SelectedDate == date)
            return;
        SelectedDate = date;
        OnChange?.Invoke();
    }
}
