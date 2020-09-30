using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicLibraryApplication
{
    class Book
    {
        private int bookID;
        private string bookName;
        private string authorName;
        private int pages;
        private string path = "books.txt";
        

        public Book()
        {
        }

        public Book(int bookID, string bookName, string authorName,int page)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.authorName = authorName;
            this.pages = page;
           
        }

        /// <summary>
        /// this method reads all the entries from file to book list
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<Book> ReadFromFile(string path)
        {
            List<Book> _bookList = new List<Book>();
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);

                StreamReader streamReader = new StreamReader(fileStream);

                while (streamReader.Peek() != -1)
                {

                    string record = streamReader.ReadLine();
                    if (record != "")
                    {
                       
                     string[] fields = record.Split(',');
                        _bookList.Add(new Book(int.Parse(fields[0]), fields[1], fields[2], int.Parse(fields[3])));
                    }
                    else
                    {
                        continue;
                    }
                }




                Console.WriteLine("The Read operation has ended");

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
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

            return _bookList;
            

        }

        /// <summary>
        /// this method imports the data in main file from another file
        /// </summary>
        /// <param name="_bList"></param>
        public void ImportToFile(List<Book> _bList)
        {

            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {

                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

                streamWriter = new StreamWriter(fileStream);
            foreach (Book book in _bList) { 

                streamWriter.WriteLine(book.BookID + "," + book.BookName + "," + book.AuthorName + "," + book.Pages);
            }

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

        }

        /// <summary>
        /// this method returns a book using the list index
        /// </summary>
        /// <param name="indx"></param>
        /// <returns></returns>
        public Book getBook(int indx)
        {
            Book b=new Book();
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);

                StreamReader streamReader = new StreamReader(fileStream);

                while (streamReader.Peek() != -1)
                {

                    string record = streamReader.ReadLine();
                    if (record != "")
                    {
                        
                        string[] fields = record.Split(',');
                        if (int.Parse(fields[0]) == indx)
                        {
                            b = new Book(int.Parse(fields[0]), fields[1], fields[2], int.Parse(fields[3]));
                            
                        }
                    }
                    else
                    {
                        continue;
                    }
                }




                Console.WriteLine("The Read operation has ended");

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
                if (fileStream != null)
                {
                    fileStream.Close();
                }

            }
            return b;


        }

        public int BookID { get => bookID; set => bookID = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public int Pages { get => pages; set => pages = value; }
    }
}
