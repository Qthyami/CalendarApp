using Microsoft.AspNetCore.Components;

public class BaseComponent: ComponentBase {
    [Parameter] public string Class {get;set;}
    [Parameter] public string Style {get;set;}
}
