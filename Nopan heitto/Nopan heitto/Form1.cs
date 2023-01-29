namespace Nopan_heitto
{
    public partial class NopanHeitto : Form
    {
        public NopanHeitto()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(Noppa01PB);
            piirraNoppa(Noppa02PB);
        }
        private void piirraNoppa(PictureBox Noppabox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch(noppa)
            {
                case 1:
                    Noppabox.Image = Properties.Resources.dice01;
                        break;
                case 2:
                    Noppabox.Image = Properties.Resources.dice02;
                        break;
                case 3:
                    Noppabox.Image = Properties.Resources.dice03;
                        break;
                case 4:
                    Noppabox.Image = Properties.Resources.dice04;
                        break;
                case 5:
                    Noppabox.Image = Properties.Resources.dice05;
                        break;
                case 6:
                    Noppabox.Image = Properties.Resources.dice06;
                        break;
            }

        }
    }
}