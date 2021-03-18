using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
