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
    public partial class issue : Form
    {
        Librarian l;
        Book _book;

        public issue()
        {
            l = new Librarian();
            InitializeComponent();
            display();
            _book = new Book();
        }


        /// <summary>
        /// This method reads all the entries from the file and displays in the list
        /// </summary>
        private void display()
        {
            _lstBooks.Items.Clear();
            List<String> list = l.ReadFromFile("issueBooks.txt");


            foreach (string s in list)
            {
                string[] row = s.Split(',');
                string[] input = { row[0], row[1], row[2], row[3], row[4] };
                ListViewItem listViewItem = new ListViewItem(row);
                _lstBooks.Items.Add(listViewItem);
            }
            list.Clear();
        }


        /// <summary>
        /// this method changes the error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _msgError.Text = "Double Click on a Book to Issue it!";
        }

        /// <summary>
        /// this method issues the book and adds the entry to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _lstBooks_DoubleClick(object sender, EventArgs e)
        {
            string item = _lstBooks.SelectedItems[0].Text;
            Book b1 = _book.getBook(int.Parse(item));
            l.IssueBook(b1.BookID);


        }

        /// <summary>
        /// refresh list method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _refresh_Click(object sender, EventArgs e)
        {
            display();
        }

        /// <summary>
        /// exit to last form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new books().Show();
        }

    }
}
