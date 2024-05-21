using Services;

namespace BookManagement
{
    public partial class BookManagerMainUI : Form
    {
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        public void BookManagerMainUI_Load(object sender, EventArgs e) { 
            BookService service = new BookService();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = service.GetAllBook();
        }
    }
}
