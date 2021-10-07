﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string path { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int TotPages { get; set; }
    }
}
