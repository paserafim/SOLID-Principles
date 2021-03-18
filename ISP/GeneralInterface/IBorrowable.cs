using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }

        void checkIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
