namespace Tehtävien_tarkastus
{
    public partial class VastausLomakeForm : Form
    {
        int Laskuri = 0;
        int oikein = 0;
        string[] oikeatvastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        public VastausLomakeForm()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

        }

        private void DummyRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VastausCRB_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && Laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[Laskuri] = radioButton.Text;
                Laskuri++;
                KysymysLB.Text = "Vastaus" + Laskuri + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 0; j < 10; j++)

                {
                    if (vastaukset[j] == oikeatvastaukset[j])
                    {
                        oikein++;
                    }

                }
                VastausLB.Text = "oikeita vastauksia oli:" + oikein;
                VastausLB.Visible = true;

            }
            Tyhjaavastaus();
        }
         private void Tyhjaavastaus()
        {
            if (VastausARB.Checked == true)

            {
                VastausARB.Checked = false;
                Laskuri--;
            }
            if (VastausBRB.Checked == true)

            {
                VastausBRB.Checked = false;
                Laskuri--;
            }
            if (VastausCRB.Checked == true)

            {
                VastausCRB.Checked = false;
                Laskuri--;
            }
            if (VastausDRB.Checked == true)

            {
                VastausDRB.Checked = false;
                Laskuri--;
            }
            
            }

        }
            

            }
        
    





    
