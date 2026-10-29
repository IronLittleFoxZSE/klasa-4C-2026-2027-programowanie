/*
Formularz zgłoszenia usterki

Napisz aplikację umożliwiającą wpisanie opisu usterki, np. niedziałającego komputera w pracowni. Całość umieść na jednej stronie.
- Dodaj Label z instrukcją „Opisz zauważoną usterkę”.
- Dodaj Editor do wpisania opisu.
- Dodaj Button z tekstem „Wyślij zgłoszenie”. Przycisk ma być dostępny tylko wtedy, gdy opis zawiera przynajmniej jeden znak inny niż spacja.
- Napisz konwerter NonEmptyTextConverter, który zwraca false dla pustego tekstu, samych białych znaków lub null, a w pozostałych przypadkach true.
- Zarejestruj konwerter w zasobach strony. Powiąż IsEnabled przycisku z Text edytora, wykorzystując konwerter. Dostępność przycisku ma zmieniać się podczas pisania.
Logika konwertera może sprowadzać się do jednego sprawdzenia za pomocą string.IsNullOrWhiteSpace.
*/
namespace FaultReportMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
