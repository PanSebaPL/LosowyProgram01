namespace Rachunki
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn10napwiek(object sender, EventArgs e)
        {
            float Cost;
            if (EntryCost.Text == null)
                EntryCost.Text = "0";
            float.TryParse(EntryCost.Text, out Cost);
            LblNapiwekPerc.Text = "10%";

            float Conv = (float)(Cost * 0.1);
            LblNapiwek.Text = Conv.ToString("0.00");
            Cost = Conv + Cost;
            LblSuma.Text= Cost.ToString("0.00");
            SemanticScreenReader.Announce(LblNapiwek.Text);
            SemanticScreenReader.Announce(LblNapiwekPerc.Text);
            SemanticScreenReader.Announce(LblSuma.Text);
        }
        private void btn7napwiek(object sender, EventArgs e)
        {
            float Cost;
            if (EntryCost.Text == null)
                EntryCost.Text = "0";
            float.TryParse(EntryCost.Text, out Cost);
            LblNapiwekPerc.Text = "7%";

            float Conv = (float)(Cost * 0.07);
            LblNapiwek.Text = Conv.ToString("0.00");
            Cost = Conv + Cost;
            LblSuma.Text = Cost.ToString("0.00");
            SemanticScreenReader.Announce(LblNapiwek.Text);
            SemanticScreenReader.Announce(LblNapiwekPerc.Text);
            SemanticScreenReader.Announce(LblSuma.Text);


        }
        private void btnzakdol(object sender, EventArgs e)
        {
            if(LblSuma.Text!= null)
            {
                float Sum; float.TryParse(LblSuma.Text, out Sum);
                Sum = float.Floor(Sum);
                LblSuma.Text = Sum.ToString("0.00");
                SemanticScreenReader.Announce(LblSuma.Text);
            }
        }
        private void btnzakgor(object sender, EventArgs e)
        {
            if (LblSuma.Text != null)
            {
                float Sum; float.TryParse(LblSuma.Text, out Sum);
                Sum = float.Ceiling(Sum);
                LblSuma.Text= Sum.ToString("0.00");
                SemanticScreenReader.Announce(LblSuma.Text);
                
            }
        }
        private void SldCalc(object sender, EventArgs e)
        {
            double Val = SldAmount.Value;
            LblNapiwek.Text = Val.ToString();
        }
    }
}