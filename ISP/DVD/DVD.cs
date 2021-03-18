using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class DVD : IBorrowableDVD
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }


        public void checkIn()
        {
            Borrower = "";
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {

            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
