using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using Entity;

namespace Library_Management
{
    class Database
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v13.0;AttachDbFilename=F:\Visual Studio Projects\Library Management\Library Management\Library.mdf;Integrated Security=True");
        //Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\2nd year, 2nd term\Visual Studio Projects\Hospital Management\Hospital Management\hospital.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public bool saveNewBook(Book b)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "insert into books values ('" + b.ID + "','" + b.title + "','" + b.author + "',0,'" + b.quantity + "','" + b.condition + "','" + b.deadline + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into locate values ('" + b.ID + "','" + b.section + "','" + b.Arrivaldate + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
            }
            return false;
        }
        public bool saveNewSection(string secction, string shelf)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "insert into location values ('" + secction + "','" + shelf + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
            }
            return false;
        }
        public bool saveNewStudent(Student b)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "insert into student values ('" + b.ID + "','" + b.name + "','" + b.discipline + "','" + b.year + "','" + b.term + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Phone values ('" + b.number + "','" + b.type + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into stu_phone values ('" + b.number + "','" + b.ID + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
            }
            return false;
        }

        public Book[] readAllBooks()
        {
            cmd.Connection = cn;
            Book[] d = new Book[300];
            for(int i=0; i<300; i++)
            {
                d[i] = new Book();
            }
            try
            {
                cn.Open();
                cmd.CommandText = "select * from books where quantity>0";
                dr = cmd.ExecuteReader();
                int k = 0;
                while (dr.Read())
                {
                    d[k].ID = dr[0].ToString();
                    d[k].title = dr[1].ToString();
                    d[k].author = dr[2].ToString();
                    d[k].popularity = Convert.ToInt32(dr[3].ToString());
                    d[k].quantity = Convert.ToInt32(dr[4].ToString());
                    d[k].condition = dr[5].ToString();
                    d[k].deadline = Convert.ToInt32(dr[6].ToString());
                    k++;
                }
                cn.Close();
                Book.k = k;
                return d;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public bool checkCard(int ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "select card_number from library_card,student where stu_ID='"+ID+"' and year_=card_number";
                dr = cmd.ExecuteReader();
                dr.Read();
                int s = Convert.ToInt32(dr[0]);
                cn.Close();
                if (s > 0)
                    return true;
                //cn.Close();
                //dr.Read();
                return false;
            }
            catch (Exception el)
            {
                cn.Close();
                //MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool createNewCard(int ID)
        {
            //MessageBox.Show(ID.ToString());
            DateTime n = DateTime.Now;
            string currentDate = n.ToString();
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "select year_ from student where ID='" + ID + "'";
                dr = cmd.ExecuteReader();
                dr.Read();
                string year = dr[0].ToString();
                cn.Close();
                cn.Open();
                cmd.CommandText = "insert into library_card values ('" + ID + "','" + year + "','" + currentDate + "','1 Year',0)";
                cmd.ExecuteNonQuery();
                MessageBox.Show(ID.ToString());
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
            }
            return false;
        }
        public LibraryCard showCard(int ID)
        {
            LibraryCard lc = new LibraryCard();
            cmd.Connection = cn;
            try
            {
                //MessageBox.Show("0");
                cn.Open();
                cmd.CommandText = "select * from library_card where stu_ID='" + ID + "' and card_number in (select year_ from student where ID = '"+ID+"')";
                dr = cmd.ExecuteReader();
                lc.ID = ID;
                //MessageBox.Show("1");
                dr.Read();
                lc.cardNumber = Convert.ToInt32(dr[1]);
                lc.issueDate = dr[2].ToString();
                lc.deadline = dr[3].ToString();
                lc.numberOfBook = Convert.ToInt32(dr[4]);
                LibraryCard.k = lc.cardNumber;
                //MessageBox.Show("2");
                cn.Close();
                return lc;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show("YOU DON'T HAVE A LIBRARY CARD.");
                return null;
            }
        }
        public LibraryCard[] showAllCards(int ID)
        {
            LibraryCard[] lc = new LibraryCard[4];
            for(int i=0; i<4; i++)
            {
                lc[i] = new LibraryCard();
            }
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from library_card where stu_ID='" + ID+"'";
                dr = cmd.ExecuteReader();
                
                int i = 0;
                while (dr.Read())
                {
                    lc[i].ID = ID;
                    lc[i].cardNumber = Convert.ToInt32(dr[1]);
                    lc[i].issueDate = dr[2].ToString();
                    //MessageBox.Show(lc[i].issueDate);
                    lc[i].deadline = dr[3].ToString();
                    lc[i].numberOfBook = Convert.ToInt32(dr[4]);
                    i++;
                }
                cn.Close();
                return lc;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public int getDeadlineOfBook(int book_ID)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select deadline from books where book_ID='" + book_ID + "'";
                dr = cmd.ExecuteReader();
                dr.Read();
                int x = Convert.ToInt32(dr[0]);
                cn.Close();
                return x;
            }
            catch(Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return 0;
            }
        }
        public bool borrowBook(Takes[] t, int length)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                for (int i = 0; i < length; i++)
                {
                    cmd.CommandText = "insert into takes values ('" + t[i].book_ID + "','" + t[i].ID + "','" + t[i].date_taken + "','"+t[i].last_date+"')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update books set quantity = quantity - 1 where book_ID = '" + t[i].book_ID + "'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update books set popularity = popularity + 1 where book_ID = '" + t[i].book_ID + "'";
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public void updateLibraryCard(string ID, int length)
        {
            try
            {
                cmd.Connection = cn;
                for (int i = 0; i < length; i++)
                {
                    cn.Open();
                    cmd.CommandText = "update library_card set number_of_books=number_of_books+1 where stu_ID = '" + ID + "' and card_number in (select year_ from student where ID ='" + ID + "')";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
            }
        }

        public bool checkBorrowedBooks(int ID)
        {
            try
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "select stu_ID from takes where stu_ID='" + ID + "'";
                dr = cmd.ExecuteReader();
                dr.Read();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public List<BorrowedList> readBorrowedBooks(int ID)
        {
            cmd.Connection = cn;
            List<BorrowedList> bbl = new List<BorrowedList>();
            BorrowedList d;
            try
            {
                cn.Open();
                cmd.CommandText = "select books.book_ID,title,author,date_taken,last_return_date from books, takes where takes.stu_ID='"+ID+"' and takes.book_ID=books.book_ID";
                dr = cmd.ExecuteReader();
                int k = 0;
                while (dr.Read())
                {
                    d = new BorrowedList();
                    d.book_ID = dr[0].ToString();
                    d.title = dr[1].ToString();
                    d.author = dr[2].ToString();
                    d.takenDate = dr[3].ToString();
                    d.returnDate = dr[4].ToString();
                    bbl.Add(d);
                }
                cn.Close();
                //Book.k = k;
                return bbl;
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
                return null;
            }
            /*cmd.Connection = cn;
            Book[] d = new Book[30];
            for (int i = 0; i < 30; i++)
            {
                d[i] = new Book();
            }
            try
            {
                cn.Open();
                cmd.CommandText = "select * from books where book_ID in (select book_ID from takes where stu_ID = '"+ID+"')";
                dr = cmd.ExecuteReader();
                int k = 0;
                while (dr.Read())
                {
                    d[k].ID = dr[0].ToString();
                    d[k].title = dr[1].ToString();
                    d[k].author = dr[2].ToString();
                    d[k].popularity = Convert.ToInt32(dr[3].ToString());
                    d[k].quantity = Convert.ToInt32(dr[4].ToString());
                    d[k].condition = dr[5].ToString();
                    d[k].deadline = Convert.ToInt32(dr[6].ToString());
                    k++;
                }
                cn.Close();
                Book.k = k;
                return d;
            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
                return null;
            }*/
        }
        public bool returnBook(string ID, List<int> book_ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                for (int i = 0; i < book_ID.Count; i++)
                {
                    cmd.CommandText = "delete from takes where book_ID = '" + book_ID[i] + "' and stu_ID='"+ID+"'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update books set quantity = quantity + 1 where book_ID = '" + book_ID[i] + "'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from fined_for where book_ID='"+book_ID[i]+"' and stu_ID='"+ID+"'";
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public string readMessage(string ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "select message_,key_ from messageBox where ID = '" + ID + "'";
                dr = cmd.ExecuteReader();
                dr.Read();
                string sms = dr[0].ToString();
                string s = dr[1].ToString();
                cn.Close();
                if (s.Equals("0"))
                    return sms;
                else
                    return null;         
            }
            catch (Exception el)
            {
                cn.Close();
                return null;
            }
        }
        public List<string> readAllSections()
        {
            List<string> sections = new List<string>();
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "select distinct section from location";
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    sections.Add(dr[0].ToString());
                }
                cn.Close();
                return sections;
            }
            catch (Exception el)
            {
                cn.Close();
                return null;
            }
        }
        public List<Book> readBooksFromSection(string section)
        {
            cmd.Connection = cn;
            List<Book> bo = new List<Book>();
            Book d;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from books where quantity>0 and book_ID in (select book_ID from locate where section = '"+section+"')";
                dr = cmd.ExecuteReader();
                //int k = 0;
                while (dr.Read())
                {
                    d = new Book();
                    d.ID = dr[0].ToString();
                    d.title = dr[1].ToString();
                    d.author = dr[2].ToString();
                    d.popularity = Convert.ToInt32(dr[3].ToString());
                    d.quantity = Convert.ToInt32(dr[4].ToString());
                    d.condition = dr[5].ToString();
                    d.deadline = Convert.ToInt32(dr[6].ToString());
                    //MessageBox.Show(d.ID);
                    bo.Add(d);
                   
                }
                cn.Close();
                //Book.k = k;
                //MessageBox.Show(bo[0].ID);
                return bo;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public bool sendRequest(int ID, string requestMessage)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "insert into request values ('"+ID+"', '"+requestMessage+"','"+-1+"')";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                //MessageBox.Show(el.Message);
                return false;
            }
        }
        public string readAllSection()
        {
            cmd.Connection = cn;
            string section = "";
            try
            {
                cn.Open();
                cmd.CommandText = "select * from location";
                dr = cmd.ExecuteReader();
                //int k = 0;
                while (dr.Read())
                {
                    section += dr[0].ToString();
                    section += " - ";
                    section += dr[1].ToString();
                    section += Environment.NewLine;
                }
                cn.Close();
                //Book.k = k;
                return section;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }

        public updateData readUpdateData(int ID)
        {
            cmd.Connection = cn;
            updateData ud = new updateData();
            //updateData2 temp = new updateData2();
            //List<updateData2> ud2 = new List<updateData2>();
            try
            {
                cn.Open();
                cmd.CommandText = "select name,term from student where ID='"+ID+"'";
                dr = cmd.ExecuteReader();
                dr.Read();
                ud.name = dr[0].ToString();
                ud.term = Convert.ToInt32(dr[1]);
                cn.Close();
                return ud;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        
        public bool updateBook(Book b)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "update books set title = '" + b.title + "',author='"+b.author+"',quantity='"+b.quantity+"',condition='"+b.condition+"',deadline='"+b.deadline+"' where book_ID = '" + b.ID + "'";
                cmd.ExecuteNonQuery();             
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool increaseOneYear()
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "update student set year_ = year_+1 where year_<4";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public List<Student> readAllStudents()
        {
            cmd.Connection = cn;
            List<Student> s = new List<Student>();
            Student d;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from student";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    d = new Student();
                    d.ID = dr[0].ToString();
                    d.name = dr[1].ToString();
                    d.discipline = dr[2].ToString();
                    d.year = Convert.ToInt32(dr[3].ToString());
                    d.term = Convert.ToInt32(dr[4].ToString());
                    s.Add(d);
                }
                cn.Close();
                return s;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public List<info> readInfo()
        {
            cmd.Connection = cn;
            List<info> s = new List<info>();
            info d;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from takes";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    d = new info();
                    d.book_ID = Convert.ToInt32(dr[0]);
                    d.ID = Convert.ToInt32(dr[1]);
                    d.date_taken = dr[2].ToString();
                    d.return_date = dr[3].ToString();
                    s.Add(d);
                }
                cn.Close();
                return s;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public List<info> readDelayInfo()
        {
            cmd.Connection = cn;
            List<info> s = new List<info>();
            info d;
            try
            {
                DateTime currentDate = DateTime.Now;
                //string currentDate = DateTime.Now.ToString("dd.MM.yy");
                //t[i].last_date = DateTime.Now.AddDays(db.getDeadlineOfBook(t[i].book_ID)).ToString("dd.MM.yy");

                cn.Open();
                cmd.CommandText = "select * from takes";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    d = new info();
                    d.book_ID = Convert.ToInt32(dr[0]);
                    d.ID = Convert.ToInt32(dr[1]);
                    d.date_taken = dr[2].ToString();
                    d.return_date = dr[3].ToString();
                    DateTime date = Convert.ToDateTime(d.return_date);
                    int result = DateTime.Compare(currentDate, date);
                    if(result>0)
                        s.Add(d);
                }
                cn.Close();
                return s;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public bool fineStudent(string book_ID,string stu_ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "Insert into fined_for values ('" + book_ID + "','" + stu_ID + "',200)";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool clearFine(string ID, List<int> book_ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                for(int i=0; i<book_ID.Count; i++)
                {
                    cmd.CommandText = "delete from fined_for where book_ID='" + book_ID[i] + "' and stu_ID='" + ID + "'";
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool checkFine(string ID)
        {
            int flag = 0;
            try
            {
                cn.Open();
                cmd.CommandText = "select fines_amount from fined_for where stu_ID='" + ID + "'";
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != null)
                    flag = 1;
                cn.Close();
                if(flag==1)
                    return true;
                return false;
            }
            catch(Exception el)
            {
                cn.Close();
                //MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool sendMessageToStudent(string stu_ID, string sms)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "update messageBox set message_='"+sms+"',key_=0 where ID='" + stu_ID + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool updateStudentInformation(string ID, string name, string term, string number,string type)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "update student set name='" + name + "',term='"+Convert.ToInt32(term)+"' where ID='" + ID + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into phone values('"+number+"','"+type+"')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into stu_phone values('" + number + "','" + ID + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool sendReply(string ID,string message)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "update messageBox set message_='" + message + "',key_=1 where ID='" + ID + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public List<Request> readAllRequests()
        {
            cmd.Connection = cn;
            List<Request> s = new List<Request>();
            Request d;
            try
            {
                cn.Open();
                cmd.CommandText = "select ID,req from request where key_=-1";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    d = new Request();
                    d.ID = dr[0].ToString();
                    d.req = dr[1].ToString();
                    s.Add(d);
                }
                cn.Close();
                return s;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public bool sendAcceptToStudent(string ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "update request set key_=1 where ID='"+ID+"'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public bool sendRejectToStudent(string ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "update request set key_=0 where ID='" + ID + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return false;
            }
        }
        public List<Book> searchBooks(string title)
        {
            cmd.Connection = cn;
            List<Book> b = new List<Book>();
            Book d;
            try
            {
                cn.Open();
                cmd.CommandText = "select * from bookswhere title like '%" + title + "%'";
                dr = cmd.ExecuteReader();
                //int k = 0;
                while (dr.Read())
                {
                    d = new Book();
                    d.ID = dr[0].ToString();
                    d.title = dr[1].ToString();
                    d.author = dr[2].ToString();
                    d.popularity = Convert.ToInt32(dr[3].ToString());
                    d.quantity = Convert.ToInt32(dr[4].ToString());
                    d.condition = dr[5].ToString();
                    d.deadline = Convert.ToInt32(dr[6].ToString());
                    //k++;
                    b.Add(d);
                }
                cn.Close();
                //Book.k = k;
                return b;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
        public int checkRequest(string ID)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.CommandText = "select key_ from requestwhere ID = '"+ID+"'";
                dr = cmd.ExecuteReader();
                //int k = 0;
                dr.Read();
                string s = dr[0].ToString();
                cn.Close();
                //Book.k = k;
                if (s.Equals("1"))
                    return 1;
                else if (s.Equals("0"))
                    return 0;
                else
                    return -1;
            }
            catch (Exception el)
            {
                cn.Close();
               // MessageBox.Show(el.Message);
                return -1;
            }
        }
        public List<Request> readAllResponse()
        {
            cmd.Connection = cn;
            List<Request> s = new List<Request>();
            Request d;
            try
            {
                cn.Open();
                cmd.CommandText = "select ID,message_ from messageBox where key_=1";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    d = new Request();
                    d.ID = dr[0].ToString();
                    d.req = dr[1].ToString();
                    s.Add(d);
                }
                cn.Close();
                return s;
            }
            catch (Exception el)
            {
                cn.Close();
                MessageBox.Show(el.Message);
                return null;
            }
        }
    }
}
