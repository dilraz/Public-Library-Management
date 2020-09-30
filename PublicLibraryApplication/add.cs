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
    public partial class add : Form
    {
        private Librarian l;
        private Book b;
        public add()
        {
            InitializeComponent();
            l = new Librarian();
        }

        /// <summary>
        /// this method gets the field values and passes  to addbook function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _addButton_Click(object sender, EventArgs e)
        {
            try { 
            int id = int.Parse(_id.Text);
            string name = _name.Text;
            string aName = _aName.Text;
            int pages = int.Parse(_pages.Text);
            b = new Book(id, name, aName, pages);
            l.AddBook(b);

            Close();
            }
            catch { Console.WriteLine("Enter Input"); }
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

        /// <summary>
        /// this method only allow numbers in the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pages_KeyPress(object sender, KeyPressEventArgs e)
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
