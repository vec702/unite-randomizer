using UNITE_Randomizer;

namespace UniteWheel
{
    public partial class Form1 : Form
    {
        private bool CLICKED = false;
        public static bool CONNECTED = false;
        public static string CHANNEL = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CLICKED) { return; }
            CLICKED = true;

            pictureBox1.BringToFront();

            Random random = new Random();

            for (int i = 100; i > 1; i -= 10)
            {
                int pokeIndex = random.Next(Dictionary.Pokemon.Count);
                Pokemon p = Dictionary.Pokemon[pokeIndex];
                int moveAIndex = random.Next(p.MoveA.Count);
                int moveBIndex = random.Next(p.MoveB.Count);
                int imgIndex = imageList1.Images.IndexOfKey($"{p.Name.ToLower()}.jpg");
                if (imgIndex < 0) MessageBox.Show($"{p.Name.ToLower()}.jpg");
                pictureBox1.Image = imageList1.Images[imgIndex];
                textBox1.Text = p.MoveA[moveAIndex].ToString();
                textBox2.Text = p.MoveB[moveBIndex].ToString();

                Thread.Sleep(1800 / i);
                Application.DoEvents();
            }
            CLICKED = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary.LoadPokemon();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UNITE_Randomizer.ConnectTwitch connectTwitch = new UNITE_Randomizer.ConnectTwitch();
            connectTwitch.UpdateToolStripLabel += this.UpdateToolStripLabel;
            if (!IsFormOpen(typeof(ConnectTwitch)))
            {
                connectTwitch?.Show();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            UNITE_Randomizer.ConnectTwitch connectTwitch = new UNITE_Randomizer.ConnectTwitch();
            connectTwitch.UpdateToolStripLabel += UpdateToolStripLabel;
            if (!IsFormOpen(typeof(ConnectTwitch)))
            {
                connectTwitch?.Show();
            }
        }

        private bool IsFormOpen(Type formType)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
        }

        private void UpdateToolStripLabel(object? sender, string text)
        {
            toolStripLabel1.Text = text;
        }
    }
}
