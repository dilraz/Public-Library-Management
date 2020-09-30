using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicLibraryApplication
{
    public partial class booksGuest : Form
    {
        private Book _book;
        private Librarian l = new Librarian();
        private string path = "books.txt";
        private List<Book> _books;
        public booksGuest()
        {
            InitializeComponent();
            _lstBooks.Sort();
            _book = new Book();
            display();
            _books = new List<Book>();
            _name.Text = "Hello There! Guest";
        }



        /// <summary>
        /// This method reads all the entries from the file and displays in the list
        /// </summary>
        private void display()
        {
            _lstBooks.Items.Clear();
            List<Book> books = l.sortBook();


            foreach (Book book in books)
            {
                string[] row = { book.BookID.ToString(), book.BookName, book.AuthorName, book.Pages.ToString() };
                ListViewItem listViewItem = new ListViewItem(row);
                _lstBooks.Items.Add(listViewItem);
            }
            books.Clear();
        }



        /// <summary>
        /// this method refreshes the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _refresh_Click(object sender, EventArgs e)
        {
            display();
        }



        /// <summary>
        /// this method opens the search form with roles (1-librarian || 2-guest)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            new search(2).Show();
        }



        /// <summary>
        /// this method return the list control
        /// </summary>
        /// <returns></returns>
        public ListView listbooks()
        {
            ListView item = _lstBooks;
            return item;
        }


     /// <summary>
     /// this method changes the error message
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        private void IssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _msgError.Text = "Double Click A Book To Request!";

        }

        /// <summary>
        /// this method opens the request book window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _lstBooks_DoubleClick(object sender, EventArgs e)
        {
            string item = _lstBooks.SelectedItems[0].Text;
            Book b1 = _book.getBook(int.Parse(item));

            this.Hide();
           
            new request(b1.BookID,b1.BookName).Show();
        }


        /// <summary>
        /// exit method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// go to home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new _roleForm().Show();
        }
    }
}
