namespace Books
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Test", "Ivan Petkov", 10);

            Console.WriteLine(book.ToString());

            GoldenEditionBook goldenEditionBook = new GoldenEditionBook("Golden", "Dimi Dimitrova", 12.5);
            Console.WriteLine(goldenEditionBook.ToString());
        }
    }
}