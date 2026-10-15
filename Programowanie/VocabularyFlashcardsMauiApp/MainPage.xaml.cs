/*
Zadanie – Fiszki do nauki słówek

Napisz aplikację w .NET MAUI, która pomaga powtarzać angielskie
słówka. Całość umieść na jednej stronie MainPage, bez nawigacji.

Przygotuj w programie kolekcję fiszek. Każda fiszka powinna
przechowywać angielskie słowo i jego polskie tłumaczenie:
- apple – jabłko,
- house – dom,
- dog – pies,
- book – książka,
- bike – rower.

Aplikacja powinna zawierać:
- CarouselView wyświetlający angielskie słowo na każdej karcie,
- IndicatorView pokazujący aktualną pozycję wśród fiszek,
- przycisk „Pokaż tłumaczenie”,
- Label pod karuzelą, przeznaczony na polskie tłumaczenie,
- przycisk „Zacznij od początku”.

Działanie aplikacji:
- po uruchomieniu wyświetlana jest pierwsza fiszka,
- użytkownik przegląda fiszki, przesuwając karty,
- początkowo tłumaczenie jest ukryte,
- po naciśnięciu „Pokaż tłumaczenie” wyświetl tłumaczenie słowa
  z aktualnie widocznej karty,
- po zmianie fiszki wyczyść tłumaczenie, aby użytkownik mógł
  samodzielnie przypomnieć sobie znaczenie kolejnego słowa,
- przycisk „Zacznij od początku” wyświetla pierwszą fiszkę
  i również czyści tłumaczenie.

Angielskie słowo na karcie wyświetl za pomocą bindingu.

Przykład:
Aktualna karta: house
Przed naciśnięciem przycisku: tłumaczenie niewidoczne.
Po naciśnięciu „Pokaż tłumaczenie”: dom.
Po przejściu do kolejnej fiszki: tłumaczenie ponownie niewidoczne.
*/

namespace VocabularyFlashcardsMauiApp
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
