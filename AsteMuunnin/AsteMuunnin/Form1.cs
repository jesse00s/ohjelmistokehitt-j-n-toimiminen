namespace AsteMuunnin
{
    public partial class AsteMuunninForm : Form
    {
        public AsteMuunninForm()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + "Fahrenheittia on " + vastaus + "celsius astetta";
                VastausLB.Visible = true;
                
            }
             else if(FahreinheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + "Celsiusta on " + vastaus + "Fahrenheit astetta";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "et valinnut muunnettavaa astetta tai et antanut oikeaa lukua";
                VastausLB.Visible = true;
            }


        }
    }
}
