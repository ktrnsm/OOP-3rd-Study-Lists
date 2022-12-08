using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3rd_Study_Lists.Models
{
    public class Writer
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public List<Book> Books { get; set; }

        public string ReflectInfo()
        {
        return $"{Name}{LastName}";
        }


    }
}
