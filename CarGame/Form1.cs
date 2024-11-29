using System.Threading;

namespace CarGame
{
    public partial class CarRace : Form
    {
        private Thread thread1;
        private Thread thread2;
        private bool isRunning = true;
        public CarRace()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            isRunning = true;
            thread1 = new Thread(() => MovePicture(pictureBox1));
            thread2 = new Thread(() => MovePicture(pictureBox2));
            thread1.Start();
            thread2.Start();
        }
        private void buttonSelectImages_Click_1(object sender, EventArgs e)
        { 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileNames.Length >= 2)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[0]);
                    pictureBox2.Image = Image.FromFile(openFileDialog1.FileNames[1]);
                    isRunning = true;
                }
                else
                {
                    MessageBox.Show("Lütfən, ən azı iki şəkil seçin.");
                }
            }
        }
        private void MovePicture(PictureBox pictureBox)
        {
            Random random = new Random();
            while (isRunning && pictureBox.Location.X < pictureBox3.Location.X - pictureBox.Width)
            {
                Invoke(new Action(() =>
                {
                    pictureBox.Location = new Point(pictureBox.Location.X + random.Next(1, 10), pictureBox.Location.Y);
                }));

                Thread.Sleep(50);
            }

            if (isRunning)
            {
                isRunning = false;

                string winner = pictureBox == pictureBox1 ? "PictureBox 1" : "PictureBox 2";
                Invoke(new Action(() =>
                {
                    MessageBox.Show($"{winner} qazandı!");
                    ResetGame();
                }));
            }
        }

        private void ResetGame()
        {
            pictureBox1.Location = new Point(10, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(10, pictureBox2.Location.Y);
           
            isRunning = false;
        }

        

        
    }
}


