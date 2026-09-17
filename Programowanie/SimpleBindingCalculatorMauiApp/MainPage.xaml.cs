namespace SimpleBindingCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string StrFirstNumber { get; set; }
        public string StrSecondNumber { get; set; }

        private string resultMessage;

        public string ResultMessage
        {
            get { return resultMessage; }
            set 
            { 
                resultMessage = value;
                OnPropertyChanged();
            }
        }

        private Color returnColor;

        public Color ReturnColor
        {
            get { return returnColor; }
            set { returnColor = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //pobrać dane wejściowe
            //var firstNumber = int.Parse(firstNumberEntry.Text);
            //int firstNumber;
            if (int.TryParse(StrFirstNumber, out int firstNumber)
                && int.TryParse(StrSecondNumber, out int secondNumber))
            {
                //wykonać operację dodawania
                //wyświetlić wynik
                ResultMessage = $"Wynik dodawania to {firstNumber + secondNumber}";
                ReturnColor = Colors.Green;
            }
            else
            {
                ResultMessage = $"Podałeś nieprawidłowe dane.";
                ReturnColor = Colors.Red;
            }

        }
    }
}
