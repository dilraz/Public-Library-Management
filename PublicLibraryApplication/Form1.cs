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
    public partial class _roleForm : Form
    {
        public _roleForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// this method opens librarian login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            (new books()).Show();
            this.Hide();

        }

        /// <summary>
        /// guest login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            (new booksGuest()).Show();
            this.Hide();

        }


    }
}
