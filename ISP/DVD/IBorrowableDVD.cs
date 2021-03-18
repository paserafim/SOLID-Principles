using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    // It is better to jion 2 interface in one then you can use these type and
    // get all the properties and methods and is called.
    public interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}
