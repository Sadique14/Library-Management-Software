using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    public class Book
    {
        public string ID;
        public string title;
        public string author;
        public Int32 quantity;
        public string condition;
        public Int32 deadline;
        public string section;
        public string Arrivaldate;
        public Int32 popularity;
        public string arrival_date;
        public int self_no;

        public static int k;
        public Book()
        {
            ID = null;
        }
    }
}
