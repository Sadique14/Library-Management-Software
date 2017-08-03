using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LibraryCard
    {
        public int ID;
        public int cardNumber;
        public string issueDate;
        public string deadline;
        public int numberOfBook;
        public LibraryCard()
        {
              ID=0;
               cardNumber=0;
              issueDate=null;
              deadline=null;
           numberOfBook=0;
    }
        public static int k;
    }
}
