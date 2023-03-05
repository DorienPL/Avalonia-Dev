using System.Collections.Generic;

namespace AppTest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Witaj w aplikacji pomagającej tworzyć rozpiski do armii!";
    
    public string Testujemy => "Testowy napis";
    private ListView _test => new ListView();
    public List<string> test => _test.Armia;
}