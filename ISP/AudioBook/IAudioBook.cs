using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public interface IAudioBook : ILibraryItem
    {
        public int RuntimeInMinutes { get; set; }
    }
}
