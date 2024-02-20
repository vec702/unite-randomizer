namespace UniteWheel
{
    public partial class Form1 : Form
    {
        private bool CLICKED = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CLICKED) { return; }
            CLICKED = true;
            
            pictureBox1.BringToFront();

            for(int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int pokeIndex = random.Next(Dictionary.Pokemon.Count);
                Pokemon p = Dictionary.Pokemon[pokeIndex];
                int moveAIndex = random.Next(p.MoveA.Count);
                int moveBIndex = random.Next(p.MoveB.Count);
                int imgIndex = imageList1.Images.IndexOfKey($"{p.Name.ToLower()}.jpg");
                if (imgIndex < 0) MessageBox.Show($"{p.Name.ToLower()}.jpg");
                pictureBox1.Image = imageList1.Images[imgIndex];
                textBox1.Text = p.MoveA[moveAIndex].ToString();
                textBox2.Text = p.MoveB[moveBIndex].ToString();

                Thread.Sleep(15);
                Application.DoEvents();
            }
            CLICKED = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary.LoadPokemon();
        }
    }
}
