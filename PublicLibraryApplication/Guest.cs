using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicLibraryApplication
{
    class Guest
    {
        private string GName;
        private string GEmail;
        private string path = "issueBooks.txt";
        Book b = new Book();
        public Guest()
        {
        }

        public Guest(string gName, string gEmail)
        {
            this.GName = gName;
            this.GEmail = gEmail;
        }

        public string GName1 { get => GName; set => GName = value; }
        public string GEmail1 { get => GEmail; set => GEmail = value; }


        /// <summary>
        /// this method adds a request entry to file from guest
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="guestName"></param>
        /// <param name="guestEmail"></param>
        public void RequestBook(int id, string name,string guestName,string guestEmail)
        {
            Guest g1 = new Guest();
                g1.GName1 = guestName;
            g1.GEmail1 = guestEmail;
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {

                fileStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);

                streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine(id + "," + name + "," + g1.GName1 + "," + g1.GEmail1 + ",requested");


                Console.WriteLine("Write is done");

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");

            }
            finally
            {
                if (streamWriter != null)
                {

                    streamWriter.Close(); // closing the writer
                }
            }
            new booksGuest().Show();
        }

        /// <summary>
        /// this method searches a book from the file using id,Bookname or authorname
        /// </summary>
        /// <param name="book"></param>
        public void SearchBook(Book book)
        {
            List<Book> b1 = b.ReadFromFile("books.txt");
            booksGuest booksG = new booksGuest();

            ListView item = booksG.listbooks();
            for (int i = 0; i < b1.Count; i++)
            {
                if (item.Items[i].SubItems[0].Text == book.BookID.ToString())
                {
                    item.Items[i].Selected = true;
                }
                else if (item.Items[i].SubItems[1].Text == book.BookName)
                {
                    item.Items[i].Selected = true;
                }
                else if (item.Items[i].SubItems[2].Text == book.AuthorName)
                {
                    item.Items[i].Selected = true;
                }
            }
            booksG.Show();
        }


    }
}
