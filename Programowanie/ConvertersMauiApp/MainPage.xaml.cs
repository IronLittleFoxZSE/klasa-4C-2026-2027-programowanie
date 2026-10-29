namespace ConvertersMauiApp
{
    public partial class MainPage : ContentPage
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set 
            { 
                grade = value;
                OnPropertyChanged();

                switch (grade)
                {
                    case 1:
                        TextGrade = "Niedostateczny";
                        break;
                    case 2:
                        TextGrade = "Dopuszczający";
                        break;
                    default:
                        break;
                }
            }
        }

        private string textGrade;

        public string TextGrade
        {
            get { return textGrade; }
            set { textGrade = value; OnPropertyChanged(); }
        }


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            box.Color = new Color(100, 200, 255);
            
        }
    }
}
