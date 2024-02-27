namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Botão clicado {count} vez";
            else
                CounterBtn.Text = $"Botão clicado {count} vezes";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnHello(object sender, EventArgs e)
        {
            string nome = textInput.Text;
            HelloLabel.Text = $"Hello, {nome}";
            SemanticScreenReader.Announce(textInput.Text);
        }
    }

}
