namespace Ikälaskuri
{
    public partial class IkaForm : Form
    {
        public IkaForm()
        {
            InitializeComponent();
        }

        private void VuosinaLB_Click(object sender, EventArgs e)
        {

        }

        private void LaskeIkaTB_Click(object sender, EventArgs e)
        {
            DateTime Synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - Synttari).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta ";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " Kuukautta";
            PaivinaLB.Text = erotus + "Päivää ";
            TunteinaLB.Text = (erotus * 24) + "Tuntia";
            MinuuteinaLB.Text = (erotus * 24 * 60) + "Minuuttia";
            SekunteinaLB.Text = (erotus * 24 * 60 * 60) + "sekunteina";
            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuuteinaLB.Visible = true;
            SekunteinaLB.Visible = true;




        }
    }
}