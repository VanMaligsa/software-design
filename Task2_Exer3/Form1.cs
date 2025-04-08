using System.Reflection.Metadata.Ecma335;

namespace Task2_Exer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public abstract class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public abstract string Details();
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string Details()
            {
                return $"Magazine: {Title}, Author: {Author}, Issue: {IssueNumber}";
            }
        }

        public class EBook : Book
        {
            public string FileFormat { get; set; }

            public override string Details()
            {
                return $"E-Book: {Title}, Author: {Author}, Format: {FileFormat}";
            }
        }

        public class BookInfo
        {
            public static List<string> InformationBooks(List<Book> books)
            {
                List<string> details = new List<string>();

                foreach (var book in books)
                {
                    details.Add(book.Details());
                }

                return details;
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>
            {
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new EBook { Title = "C# Software Design", Author = "Riane Cano", FileFormat = "PDF" },
            };

            List<string> BookStuff = BookInfo.InformationBooks(books);

            ListBoxBooks.Items.Clear();
            foreach(var info in BookStuff)
            {
                ListBoxBooks.Items.Add(info);
            }
        }
    }
}
