namespace speedchat_win
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 140;
            const int newHeight = 90;

            window.Width = newWidth;
            window.Height = newHeight;

            return window;
        }
    }
}
