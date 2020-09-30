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
    public partial class edit : Form
    {
        Book b;
        Librarian l;
        
        public edit(int id, string name, string aname, int pages)
        {
            InitializeComponent();
            _id.Text = id.ToString();
            _name.Text = name;
            _aName.Text = aname;
            _pages.Text = pages.ToString();
            l = new Librarian();
        }

       /// <summary>
       /// this method gets the updated information for a book and passes to update function
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void _editButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(_id.Text);
                string name = _name.Text;
                string aName = _aName.Text;
                int pages = int.Parse(_pages.Text);
                b = new Book(id, name, aName, pages);
                l.UpdateInfo(b);

                (new books()).Show();
                this.Close();
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
