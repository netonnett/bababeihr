namespace bababeihr
{

    public partial class Form1 : Form
    {

        System.Media.SoundPlayer meowmeow =
        new System.Media.SoundPlayer(Properties.Resources.catagressive);

        string caty = "meow";
        string qurkysmile = "😏";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            meowmeow.Play();

            MessageBox.Show(caty + qurkysmile);

            textBox1 = "youre a cute cat";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}