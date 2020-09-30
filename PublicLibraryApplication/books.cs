using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicLibraryApplication
{
    public partial class books : Form
    {
        private Book _book;
        private Librarian l = new Librarian();
        private string path = "books.txt";
        private List<Book> _books;
        
        public books()
        {
            InitializeComponent();
            _lstBooks.Sort();
            _book = new Book();
            display();
            _books = new List<Book>();
            l.LName = "Librarian";
            _name.Text = "Hello There! " + l.LName;


        }

        /// <summary>
        /// This method reads all the entries from the file and displays in the list
        /// </summary>
        private void display()
        {
            _lstBooks.Items.Clear();
            List<Book> books=l.sortBook();
        
            
            foreach (Book book in books)
            {
                string[] row = { book.BookID.ToString(),book.BookName,book.AuthorName,book.Pages.ToString() };
                ListViewItem listViewItem = new ListViewItem(row);
                _lstBooks.Items.Add(listViewItem);
            }
            books.Clear();
        }


        
        /// <summary>
        /// This method read all entries from a new file and sends them to import method to add to the main file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lstBooks.Items.Clear();
            List<Book> books = new List<Book>();
            List<Book> final = new List<Book>();
            openFileDialogBooks.Filter = "txt files (*.txt)|*.txt";
            openFileDialogBooks.InitialDirectory =
                 Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory())); ;
            DialogResult result = openFileDialogBooks.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialogBooks.FileName;
                books = _book.ReadFromFile(fileName);
                _books = _book.ReadFromFile(path);
                foreach (Book book in _books)
                {
                    final.Add(new Book(book.BookID, book.BookName, book.AuthorName, book.Pages));
                }
                foreach (Book book in books)
                {
                    final.Add(new Book(book.BookID, book.BookName, book.AuthorName, book.Pages));
                }
               
                _book.ImportToFile(final);
                display();


            }
           
           
        }

        /// <summary>
        /// this method opens new form to add a new book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new add()).Show();
            
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
        /// this method gets the id of the book from list and passes to delete function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            ListView.CheckedListViewItemCollection checkedList = _lstBooks.CheckedItems;
            foreach (ListViewItem item in checkedList)
            {
                ids.Add(int.Parse(item.SubItems[0].Text));

            }
            foreach (int id in ids) { 
            l.DelBook(id);
        }
        }

        /// <summary>
        /// this method changes the error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _msgError.Text = "Double Click A Book To Edit!";
        }

        /// <summary>
        /// this method gets the  the book from list and passes to edit form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _lstBooks_DoubleClick(object sender, EventArgs e)
        {
            string item = _lstBooks.SelectedItems[0].Text;
            Book b1 =_book.getBook(int.Parse(item));

            this.Hide();
            (new edit(b1.BookID, b1.BookName, b1.AuthorName, b1.Pages)).Show();
            
        }

        /// <summary>
        /// this method opens the search form with roles (1-librarian || 2-guest)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            new search(1).Show();
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
        /// this method opens the issue book window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new issue().Show();
        }

        /// <summary>
        /// this method exits the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// this method returns to the role form page
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
