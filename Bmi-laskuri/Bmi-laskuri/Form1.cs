namespace Bmi_laskuri
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoideksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            painoideksi = Math.Round(paino / (pituus * pituus), 2);
            if(painoideksi < 18.5)
            {
                VastausLB.Text = "painoindeksisi on: " + painoideksi;
                VastausLB.ForeColor = Color.Blue;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Blue;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
           else if (painoideksi < 25)
            {
                VastausLB.Text = "painoindeksisi on: " + painoideksi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else if (painoideksi < 40)
            {
                VastausLB.Text = "painoindeksisi on: " + painoideksi;
                VastausLB.ForeColor = Color.DarkOrange;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.DarkOrange;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "painoindeksisi on: " + painoideksi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
                KuvausLB.Visible = true;
            }
        }
    }
}