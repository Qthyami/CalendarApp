using Microsoft.AspNetCore.Components;

namespace CalendarApp;

public class BaseComponent: ComponentBase {
    [Parameter] public string Class {get;set;}
    [Parameter] public string Style {get;set;}
}
