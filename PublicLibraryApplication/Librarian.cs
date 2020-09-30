using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicLibraryApplication
{
    class Librarian
    {
        private string lName;
        private int pin;
        private string path = "books.txt";
        private Book b = new Book();
        public Librarian(string lName, int pin)
        {
           this.lName = lName;
            this.pin = pin;
        }

        public Librarian()
        {

        }

        public string LName { get => lName; set => lName = value; }
        public int Pin { get => pin; set => pin = value; }

        /// <summary>
        /// this method adds a new book entry to the file
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {

                fileStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);

                streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine(book.BookID + "," + book.BookName + "," + book.AuthorName + "," + book.Pages);


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
        /// this method deletes a book from the file 
        /// </summary>
        /// <param name="id"></param>
        public void DelBook(int id)
        {
           
            
            int index =0;
                List<Book> _list= new List<Book>();
                FileStream fileStream = null;
                StreamWriter streamWriter = null;

            try
            {
                _list = b.ReadFromFile(path);
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                streamWriter = new StreamWriter(fileStream);


                List<Book> _list1 = _list;
                
                    foreach (Book book in _list1)
                    {
                        if (book.BookID == id)
                        {
                        index = _list1.IndexOf(book);
                        }
                }
                
                _list1.RemoveAt(index);
                foreach (Book book in _list1)
                {

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
        /// this method updates the book information in the file
        /// </summary>
        /// <param name="book1"></param>
        public void UpdateInfo(Book book1)
        {


            int index = 0;
            List<Book> _list = new List<Book>();
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {
                _list = b.ReadFromFile(path);
                fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                streamWriter = new StreamWriter(fileStream);


                List<Book> _list1 = _list;

                foreach (Book book in _list1)
                {
                    if (book.BookID == book1.BookID)
                    {
                        index = _list1.IndexOf(book);
                    }
                }

                _list1.RemoveAt(index);
                _list1.Add(book1);
                foreach (Book book in _list1)
                {

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
        /// this method searches a book in the file
        /// </summary>
        /// <param name="book"></param>
        public void SearchBook(Book book)
        {
            List<Book> b1 = b.ReadFromFile("books.txt");
            books books = new books();
            
            ListView item = books.listbooks();
            for (int i = 0; i < b1.Count; i++)
            {
                if (item.Items[i].SubItems[0].Text == book.BookID.ToString())
                {
                    item.Items[i].Selected = true;
                }else if(item.Items[i].SubItems[1].Text == book.BookName)
                {
                    item.Items[i].Selected = true;
                }
                else if(item.Items[i].SubItems[2].Text == book.AuthorName)
                {
                    item.Items[i].Selected = true;
                }
            }
            books.Show();
          
        }

        /// <summary>
        /// this method sorts the books by book id
        /// </summary>
        /// <returns></returns>
        public List<Book> sortBook()
        {
            Book bee = new Book();
            List<Book> _boList = bee.ReadFromFile("books.txt");
            for(int i=0;i<_boList.Count;i++)
            {
                for(int j=i+1;j<_boList.Count;j++)
                {
                    if(_boList[i].BookID > _boList[j].BookID)
                    {
                        Book temp = new Book();
                        temp = _boList[j];

                        _boList[j] = _boList[i];
                        _boList[i] = temp;
                    }
                }
            }
          
            return _boList;
        }

        //this method replace requested entry with issued entry in the file
        public void IssueBook(int id)
        {
            List<String> issues = ReadFromFile("issueBooks.txt");
            string value="";
            int indx=0;
            foreach(string s in issues)
            {
                string[] row = s.Split(',');
                if(row[0]==id.ToString())
                {
                    indx = issues.IndexOf(s);
                    value = row[0] + "," + row[1] + "," + row[2] + "," + row[3] + ",issued";
                }
            }
            issues.RemoveAt(indx);
            issues.Add(value);
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {

                fileStream = new FileStream("issueBooks.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

                streamWriter = new StreamWriter(fileStream);
                foreach (string s in issues)
                {

                    streamWriter.WriteLine(s);
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
        /// this method reads requests from file as string list
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<String> ReadFromFile(string path)
        {
            List<String> issues = new List<String>();
            List<Librarian> _lList = new List<Librarian>();
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

                        issues.Add(record);
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

            return issues;


        }


    }
}
