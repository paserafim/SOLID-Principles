using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class AudioBook : ILibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; } = -1;
        public int CheckOutDurationInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
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
