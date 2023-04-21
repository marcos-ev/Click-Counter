namespace TimerClicker
{
    public partial class Form1 : Form
    {

        private int _ticks;
        private int _click;
        public Form1()
        {
            InitializeComponent();
        }

        private void star_Click(object sender, EventArgs e)
        {
            // star
            timer1.Start();
            label2.Text = "Clicks: " + _click;
            _click++;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer

            _ticks++;
            label1.Text = "Timer: " + _ticks;


            if (_ticks == 11)
            {
                timer1.Stop();
                label1.Text = "Game Over!";
                label2.Text = "Seus cliques: " + _click;
                _click = 0;
                _ticks = 0; ;
                MessageBox.Show("Seu Tempo Acabou!");

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //reset

            timer1.Stop();
            _click = 0;
            _ticks= 0;
            label1.Text = "Timer: 10";
            label2.Text = "Clicks: 0";        }
    }
}