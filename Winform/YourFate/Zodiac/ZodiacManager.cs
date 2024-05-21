using Services;

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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlImage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            // gọi thư viện để trả về cung hoàng đạo trước đó. Cần lấy được 
            // ngày, tháng sinh đang nằm trong 2 ô text. Toàn bộ gõ từ bàn phím là 
            // text, ta phải convert về số. Java: Integer.ParseInt(String)

            int day = int.Parse(txtDay.Text);
            int month = int.Parse(txtMonth.Text);

            string zodiacEn = ZodiacCalculator.GetZodiacEnglish(month, day);


            string zodiacImage = @"S:\Programming Language\C#\Document\c-sharp-craftsman\hands-on\zodiac-source\signs\" + zodiacEn + ".jpg";

            Image img = Image.FromFile(zodiacImage);

            picImage.Image = img;

            lblYourZodiac.Text = " Your zodiac sign is " + zodiacEn;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
