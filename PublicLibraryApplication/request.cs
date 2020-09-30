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
    public partial class request : Form
    {
        private int id;
        private string name;
        Guest g;
        public request(int id,string name)
        {
            InitializeComponent();
            g = new Guest();
            this.id = id;
            this.name = name;

        }

        /// <summary>
        /// this method adds a request from guest in the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _editButton_Click(object sender, EventArgs e)
        {
            try
            {
                string gName = _gName.Text;
                string email = _gEmail.Text;
                if (gName != "" & email != "")
                {
                    g.RequestBook(id, name, gName, email);
                }

            }
            catch { Console.WriteLine("Enter Input"); }
            finally { this.Hide(); new booksGuest().Show(); }
        }
    }
}
