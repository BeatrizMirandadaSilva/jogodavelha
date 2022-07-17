namespace jogodavelha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int marcador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if(marcador%2 == 0) { button1.Text = "X"; }
            else { button1.Text = "O"; }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button2.Text = "X"; }
            else { button2.Text = "O"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button3.Text = "X"; }
            else { button3.Text = "O"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button4.Text = "X"; }
            else { button4.Text = "O"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button5.Text = "X"; }
            else { button5.Text = "O"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button6.Text = "X"; }
            else { button6.Text = "O"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button7.Text = "X"; }
            else { button7.Text = "O"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button8.Text = "X"; }
            else { button8.Text = "O"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            marcador += 1;
            if (marcador % 2 == 0) { button9.Text = "X"; }
            else { button9.Text = "O"; }
        }
    }
}