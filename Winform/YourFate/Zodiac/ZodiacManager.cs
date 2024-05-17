namespace Zodiac
{
    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ZodiacManager_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            // đưa ảnh vào ram
            Image img = Image.FromFile(@"S:\Programming Language\C#\Document\c-sharp-craftsman\hands-on\zodiac-source\signs\HotGirl.jpg");

            // Show ảnh
            picImage.Image = img;
        }
    }
}
