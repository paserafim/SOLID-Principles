﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class ReferenceBook : IBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

    }
}
