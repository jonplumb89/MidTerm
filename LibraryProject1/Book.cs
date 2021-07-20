using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject1
{
    public class Book
    {
        public string BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Status { get; set; }
        public DateTime DueDate { get; internal set; }
    }
}
