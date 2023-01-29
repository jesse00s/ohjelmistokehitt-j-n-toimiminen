 using System.IO;

namespace Suosikki_nimi2
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\spann\\source\\repos\\Suosikkinimi\\pojat.txt");
            string[] Tytot = File.ReadAllLines("C:\\Users\\spann\\source\\repos\\Suosikkinimi\\Tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip =  1, laskurit = 1;
            foreach(string poju in pojat)
            {
                if (nimi == poju)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;

                }
                laskurip++;
            }
            foreach (string friidu in Tytot)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;

                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :-(";
                VastausLB.Visible = true;
            }




        }
    }
}