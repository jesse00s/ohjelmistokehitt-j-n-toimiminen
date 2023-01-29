namespace WinFormsApp3
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Jesse" && SalasanaTB.Text == "Jaakkokulta1")




            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;

            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheviestiLB.Visible = true;
            }
        }
    }
}

            

