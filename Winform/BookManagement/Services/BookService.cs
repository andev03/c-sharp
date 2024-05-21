using Repositories.Entity;

namespace Services
{
    public class BookService
    {
        public List<Book> GetAllBook()
        {
            List<Book> arr = new List<Book>();

            arr.Add(new Book() { BookId = 1, BookName = "Đời Ngắn Đừng Ngủ Dài-Short Life Don’t Sleep Long", Author = "Robin Sharma" });
            arr.Add(new Book() { BookId = 2, BookName = "Mình Là Nắng, Việc Của Mình Là Chói Chang-I Am the Sun, My Job Is to Shine Bright", Author = "Kazuko Watanabe" });
            arr.Add(new Book() { BookId = 3, BookName = "Tuổi Trẻ Đáng Giá Bao Nhiêu-How Much Is Youth Worth', N'''Tuổi trẻ đáng giá bao nhiêu?", Author = "Rosie Nguyễn" });

            return arr;
        }
    }
}
