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
    public partial class search : Form
    {
        int choice;
        Book b;
        Librarian l;
        Guest g;
        public search(int i)
        {
            InitializeComponent();
            b = new Book();
            l = new Librarian();
            g = new Guest();
            this.choice = i;
        }

        /// <summary>
        /// this method gets the search parameters and values to pass to the search function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = _id.Text;
                string name = _name.Text;
                string aName = _aName.Text;
                if (choice == 1)
                {
                    b = new Book();
                    if (id != "")
                    {
                        if (int.Parse(id) > 0)
                        {
                            b.BookID = int.Parse(id);
                        }
                    }
                    else if (name != "")
                    {
                        b.BookName = name;
                    }
                    else if (aName != "")
                    {
                        b.AuthorName = aName;
                    }
                    l.SearchBook(b);
                    this.Close();
                }
                else if (choice == 2)
                {
                    b = new Book();
                    if (id != "")
                    {
                        if (int.Parse(id) > 0)
                        {
                            b.BookID = int.Parse(id);
                        }
                    }
                    else if (name != "")
                    {
                        b.BookName = name;
                    }
                    else if (aName != "")
                    {
                        b.AuthorName = aName;
                    }
                    g.SearchBook(b);

                }
            }
            catch { Console.WriteLine("Enter Input"); }
            finally { this.Close(); }
        }

        /// <summary>
        /// this method only allow numbers in the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
