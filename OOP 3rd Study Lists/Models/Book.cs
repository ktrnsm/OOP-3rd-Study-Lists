using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3rd_Study_Lists.Models
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string Page { get; set; }
        public Writer Writer { get; set; }

        public string ReflectInfo()
        {
            return $"{BookName}{BookType}{Page}{Writer.Name}{Writer.LastName}";
        }
        
    }
}
