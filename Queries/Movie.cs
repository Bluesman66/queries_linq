﻿using System;

namespace Queries
{
    class Movie
    {
        private int _year;
        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year
        {
            get
            {                
                Console.WriteLine($"Returning {_year} for {Title}");
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
}
