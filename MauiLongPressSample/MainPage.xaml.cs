namespace MauiLongPressSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public Command LongPressCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();

            LongPressCommand = new Command(() =>
            {
                count++;

                if (count == 1)
                    CounterBtn.Text = $"Long pressed {count} time";
                else
                    CounterBtn.Text = $"Long pressed {count} times";

                SemanticScreenReader.Announce(CounterBtn.Text);
            });

            BindingContext = this;
        }

        private void OnCounterClicked(object sender, EventArgs e)
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
